import sqlite3

conn = sqlite3.connect("qlgiaodich.db")
cursor = conn.cursor()

cursor.execute("""
CREATE TABLE IF NOT EXISTS GiaoDich (
    Id INTEGER PRIMARY KEY,
    SoTaiKhoan TEXT NOT NULL,
    SoTien REAL NOT NULL,
    LoaiGiaoDich TEXT NOT NULL
)
""")

cursor.execute("DELETE FROM GiaoDich")

data = [
    (1, "1023456789", 500000, "Nap tien"),
    (2, "1023456789", 200000, "Rut tien"),
    (3, "1098765432", 1000000, "Nap tien"),
    (4, "1098765432", 150000, "Rut tien"),
    (5, "1055566677", 300000, "Nap tien")
]

cursor.executemany("""
INSERT INTO GiaoDich (Id, SoTaiKhoan, SoTien, LoaiGiaoDich)
VALUES (?, ?, ?, ?)
""", data)

conn.commit()
conn.close()

print("Da tao file qlgiaodich.db thanh cong!")