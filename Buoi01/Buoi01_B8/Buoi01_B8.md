# Buoi01_B8 - Đổi số thập phân sang nhị phân

- Sinh viên: [Nguyễn Ngọc Yến Nhi] - MSSV: [31251024414]
- Ngày: 20/10/2026
- Hình thức: bài trên giấy (mã giả, lưu đồ, bảng chạy tay)

---

## 1. Đề bài

Nhập số nguyên n ≥ 0, xuất dạng nhị phân của n. Viết mã giả, vẽ lưu đồ, chạy tay với n = 13 (kết quả 1101) và n = 6.

## 2. Vào / ra

- **Đầu vào:** số nguyên `n ≥ 0`.
- **Đầu ra:** chuỗi nhị phân `kq` biểu diễn n.

## 3. Làm tay trước

Chia liên tiếp n cho 2, ghi lại số dư mỗi lần, dừng khi thương bằng 0, rồi đọc các số dư **từ dưới lên**.

n = 13:

| Phép chia | Thương | Số dư |
|-----------|--------|-------|
| 13 : 2 | 6 | 1 |
| 6 : 2 | 3 | 0 |
| 3 : 2 | 1 | 1 |
| 1 : 2 | 0 | 1 |

Đọc số dư từ dưới lên: **1101**.

## 4. Ý tưởng thuật toán

- Số dư đầu tiên là chữ số **bên phải nhất**, số dư sau cùng là chữ số bên trái nhất. Vì vậy "đọc từ dưới lên" nghĩa là mỗi số dư mới được **ghép vào bên trái** chuỗi kết quả: `kq ← (n % 2) ghép trước kq`.
- Sau đó `n ← n / 2` (chia lấy phần nguyên).
- Lặp TRONG KHI `n > 0`.
- Trường hợp `n = 0` xử lý riêng: nếu không, vòng lặp không chạy lần nào và `kq` rỗng; kết quả đúng phải là "0".

## 5. Mã giả

```
BẮT ĐẦU
  NHẬP n
  NẾU n = 0 THÌ
    XUẤT "0"
  NGƯỢC LẠI
    kq ← ""                       // chuỗi rỗng
    TRONG KHI n > 0
      kq ← (n % 2) ghép trước kq
      n ← n / 2                   // chia lấy phần nguyên
    KẾT THÚC TRONG KHI
    XUẤT kq
  KẾT THÚC NẾU
KẾT THÚC
```

## 6. Lưu đồ

![Lưu đồ B8](images/Buoi01_B8_luudo.png)

Vòng lặp: hình thoi `n > 0 ?` nhánh Đúng đi vào hai bước xử lý, rồi quay lại hình thoi; nhánh Sai thoát ra để xuất `kq`.

## 7. Chạy tay

### n = 13 (kết quả mong đợi 1101)

| Lần lặp | n (đầu lần) | n % 2 | kq (sau khi ghép) | n / 2 (n mới) |
|---------|-------------|-------|--------------------|---------------|
| 1 | 13 | 1 | "1" | 6 |
| 2 | 6 | 0 | "01" | 3 |
| 3 | 3 | 1 | "101" | 1 |
| 4 | 1 | 1 | "1101" | 0 |
| (dừng) | 0 | | | n > 0 sai, thoát |

Kết quả xuất: **1101**. Khớp với phép làm tay ở mục 3.

### n = 6

| Lần lặp | n (đầu lần) | n % 2 | kq (sau khi ghép) | n / 2 (n mới) |
|---------|-------------|-------|--------------------|---------------|
| 1 | 6 | 0 | "0" | 3 |
| 2 | 3 | 1 | "10" | 1 |
| 3 | 1 | 1 | "110" | 0 |
| (dừng) | 0 | | | n > 0 sai, thoát |

Kết quả xuất: **110**. Kiểm tra: 1×4 + 1×2 + 0×1 = 6.

### Kiểm thử thêm: n = 0

| n | n = 0 ? | Kết quả xuất |
|---|---------|--------------|
| 0 | Đúng | 0 |

Nhờ nhánh riêng cho n = 0, kết quả đúng là "0" thay vì chuỗi rỗng.

### Tổng hợp

| n | Nhánh đi qua | Kết quả | Kiểm tra |
|---|--------------|---------|----------|
| 13 | vòng lặp 4 lần | 1101 | 8 + 4 + 0 + 1 = 13 |
| 6 | vòng lặp 3 lần | 110 | 4 + 2 + 0 = 6 |
| 0 | nhánh n = 0 | 0 | 0 |

Ba bộ dữ liệu đi qua đủ hai nhánh của hình thoi `n = 0 ?` và cả hai hướng của hình thoi `n > 0 ?`.
