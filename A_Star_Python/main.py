import tkinter as tk
from queue import PriorityQueue

# A* algoritmasında düğümler için renk tanımları
START_COLOR = "green"
END_COLOR = "red"
PATH_COLOR = "blue"
VISITED_COLOR = "yellow"
WALL_COLOR = "black"
EMPTY_COLOR = "white"

# Izgara boyutları
WIDTH = 800
ROWS = 20

# Düğüm sınıfı
class Node:
    def __init__(self, row, col, size, total_rows):
        self.row = row
        self.col = col
        self.x = row * size
        self.y = col * size
        self.color = EMPTY_COLOR
        self.size = size
        self.total_rows = total_rows
        self.neighbors = []

    def get_pos(self):
        return self.row, self.col

    def is_closed(self):
        return self.color == VISITED_COLOR

    def is_open(self):
        return self.color == PATH_COLOR

    def is_wall(self):
        return self.color == WALL_COLOR

    def is_start(self):
        return self.color == START_COLOR

    def is_end(self):
        return self.color == END_COLOR

    def reset(self):
        self.color = EMPTY_COLOR

    def make_start(self):
        self.color = START_COLOR

    def make_closed(self):
        self.color = VISITED_COLOR

    def make_open(self):
        self.color = PATH_COLOR

    def make_wall(self):
        self.color = WALL_COLOR

    def make_end(self):
        self.color = END_COLOR

    def make_path(self):
        self.color = "purple"

    def draw(self, win):
        win.create_rectangle(
            self.x, self.y, self.x + self.size, self.y + self.size, fill=self.color, outline="gray"
        )

    def update_neighbors(self, grid):
        self.neighbors = []

        # Dikey ve yatay komşular
        if self.row < self.total_rows - 1 and not grid[self.row + 1][self.col].is_wall():  # Aşağı
            self.neighbors.append(grid[self.row + 1][self.col])
        if self.row > 0 and not grid[self.row - 1][self.col].is_wall():  # Yukarı
            self.neighbors.append(grid[self.row - 1][self.col])
        if self.col < self.total_rows - 1 and not grid[self.row][self.col + 1].is_wall():  # Sağ
            self.neighbors.append(grid[self.row][self.col + 1])
        if self.col > 0 and not grid[self.row][self.col - 1].is_wall():  # Sol
            self.neighbors.append(grid[self.row][self.col - 1])

        # Çapraz komşular
        if self.row > 0 and self.col > 0 and not grid[self.row - 1][self.col - 1].is_wall():  # Sol Üst
            self.neighbors.append(grid[self.row - 1][self.col - 1])
        if self.row > 0 and self.col < self.total_rows - 1 and not grid[self.row - 1][
            self.col + 1].is_wall():  # Sağ Üst
            self.neighbors.append(grid[self.row - 1][self.col + 1])
        if self.row < self.total_rows - 1 and self.col > 0 and not grid[self.row + 1][
            self.col - 1].is_wall():  # Sol Alt
            self.neighbors.append(grid[self.row + 1][self.col - 1])
        if self.row < self.total_rows - 1 and self.col < self.total_rows - 1 and not grid[self.row + 1][
            self.col + 1].is_wall():  # Sağ Alt
            self.neighbors.append(grid[self.row + 1][self.col + 1])

    def __lt__(self, other):
        return False

# A* algoritması fonksiyonu
def h(p1, p2):
    x1, y1 = p1
    x2, y2 = p2
    return abs(x1 - x2) + abs(y1 - y2)  # Manhattan distance

def reconstruct_path(came_from, current, draw):
    while current in came_from:
        current = came_from[current]
        current.make_path()
        draw()

def algorithm(draw, grid, start, end):
    count = 0
    open_set = PriorityQueue()
    open_set.put((0, count, start))
    came_from = {}
    g_score = {node: float("inf") for row in grid for node in row}
    g_score[start] = 0
    f_score = {node: float("inf") for row in grid for node in row}
    f_score[start] = h(start.get_pos(), end.get_pos())

    open_set_hash = {start}

    while not open_set.empty():
        current = open_set.get()[2]
        open_set_hash.remove(current)

        if current == end:
            reconstruct_path(came_from, end, draw)
            end.make_end()
            return True

        for neighbor in current.neighbors:
            temp_g_score = g_score[current] + 1

            if temp_g_score < g_score[neighbor]:
                came_from[neighbor] = current
                g_score[neighbor] = temp_g_score
                f_score[neighbor] = temp_g_score + h(neighbor.get_pos(), end.get_pos())
                if neighbor not in open_set_hash:
                    count += 1
                    open_set.put((f_score[neighbor], count, neighbor))
                    open_set_hash.add(neighbor)
                    neighbor.make_open()

        draw()

        if current != start:
            current.make_closed()

    return False

### Tkinter ile Arayüz:

def make_grid(rows, width):
    grid = []
    gap = width // rows
    for i in range(rows):
        grid.append([])
        for j in range(rows):
            node = Node(i, j, gap, rows)
            grid[i].append(node)
    return grid

def draw_grid(win, rows, width):
    gap = width // rows
    for i in range(rows):
        win.create_line(0, i * gap, width, i * gap)
        win.create_line(i * gap, 0, i * gap, width)

def draw(win, grid, rows, width):
    for row in grid:
        for node in row:
            node.draw(win)
    draw_grid(win, rows, width)
    win.update()

def get_clicked_pos(pos, rows, width):
    gap = width // rows
    y, x = pos
    row = y // gap
    col = x // gap
    return row, col

def main():
    win = tk.Tk()
    win.title("A* Algoritması Görselleştirme")
    win.geometry(f"{WIDTH}x{WIDTH}")
    canvas = tk.Canvas(win, width=WIDTH, height=WIDTH)
    canvas.pack()

    grid = make_grid(ROWS, WIDTH)

    start = None
    end = None

    def mouse_click(event):
        nonlocal start, end

        row, col = get_clicked_pos((event.x, event.y), ROWS, WIDTH)
        node = grid[row][col]

        if not start and node != end:  # Başlangıç noktası seçilmediyse
            start = node
            start.make_start()

        elif not end and node != start:  # Bitiş noktası seçilmediyse
            end = node
            end.make_end()

        elif node != end and node != start:  # Duvarlar ekle
            node.make_wall()

        draw(canvas, grid, ROWS, WIDTH)

    def start_algorithm(event):
        for row in grid:
            for node in row:
                node.update_neighbors(grid)

        algorithm(lambda: draw(canvas, grid, ROWS, WIDTH), grid, start, end)

    canvas.bind("<Button-1>", mouse_click)  # Sol tık ile başlangıç, bitiş ve duvar ekle
    win.bind("<Return>", start_algorithm)  # Enter tuşu ile algoritmayı başlat

    draw(canvas, grid, ROWS, WIDTH)  # Izgarayı başlatıldığında çizdir

    win.mainloop()

if __name__ == "__main__":
    main()
