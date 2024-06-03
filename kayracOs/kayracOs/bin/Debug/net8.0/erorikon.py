import win32gui,ctypes,time,win32con

hdc = win32gui.GetDC(0)
user32 = ctypes.windll.user32
user32.SetProcessDPIAware()

while True:
    cursor_pos = win32gui.GetCursorPos()
    win32gui.DrawIcon(hdc, cursor_pos[0], cursor_pos[1], win32gui.LoadIcon(None, win32con.IDI_ERROR))
