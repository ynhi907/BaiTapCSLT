# Buoi01_B7 - Kiểm tra số nguyên tố

- Sinh viên: [Nguyễn Ngọc Yến Nhi] - MSSV: [31251024414]
- Ngày: 20/10/2026
- Hình thức: bài trên giấy (mã giả, lưu đồ, bảng chạy tay)

---

## 1. Đề bài

Nhập số nguyên `n`, xuất "Nguyên tố" hoặc "Không nguyên tố". Số nguyên tố là số lớn hơn 1 chỉ chia hết cho 1 và chính nó. Viết mã giả, vẽ lưu đồ, chạy tay với n = 7, n = 9, n = 1.

## 2. Vào / ra

- **Đầu vào:** số nguyên `n`.
- **Đầu ra:** thông báo "Nguyên tố" hoặc "Không nguyên tố".

## 3. Phân tích các trường hợp

1. `n < 2` (gồm 1, 0, số âm): không phải số nguyên tố, kết thúc ngay.
2. `n ≥ 2` và có ít nhất một số `i` trong đoạn từ 2 đến n − 1 mà `n % i = 0`: không nguyên tố.
3. `n ≥ 2` và không có `i` nào như vậy: nguyên tố.

Dùng một biến "cờ" `laNT` (có giá trị Đúng/Sai). Ban đầu giả sử n là số nguyên tố (`laNT ← Đúng`); chỉ cần tìm được một ước số `i` là đổi cờ thành Sai. Sau vòng lặp, dựa vào cờ để xuất kết quả.

## 4. Mã giả (cách cơ bản)

```
BẮT ĐẦU
  NHẬP n
  NẾU n < 2 THÌ
    XUẤT "Không nguyên tố"
  NGƯỢC LẠI
    laNT ← Đúng
    i ← 2
    TRONG KHI i ≤ n - 1
      NẾU n % i = 0 THÌ
        laNT ← Sai
      KẾT THÚC NẾU
      i ← i + 1
    KẾT THÚC TRONG KHI
    NẾU laNT = Đúng THÌ
      XUẤT "Nguyên tố"
    NGƯỢC LẠI
      XUẤT "Không nguyên tố"
    KẾT THÚC NẾU
  KẾT THÚC NẾU
KẾT THÚC
```

## 5. Lưu đồ (cách cơ bản)

![Lưu đồ cơ bản](images/Buoi01_B7_luudocoban.png)

Vòng lặp: hình thoi `i ≤ n − 1 ?` nhánh Đúng đi vào thân vòng lặp, rồi `i ← i + 1` quay lại hình thoi đó; nhánh Sai thoát ra để xét cờ `laNT`.

## 6. Chạy tay (cách cơ bản)

### n = 7

| i | n % i | laNT sau bước này |
|---|-------|-------------------|
| (khởi tạo) | | Đúng |
| 2 | 1 | Đúng |
| 3 | 1 | Đúng |
| 4 | 3 | Đúng |
| 5 | 2 | Đúng |
| 6 | 1 | Đúng |
| 7 | (i > n − 1, thoát vòng lặp) | Đúng |

Kết quả xuất: **Nguyên tố** (7 là số nguyên tố).

### n = 9

| i | n % i | laNT sau bước này |
|---|-------|-------------------|
| (khởi tạo) | | Đúng |
| 2 | 1 | Đúng |
| 3 | 0 | **Sai** |
| 4 | 1 | Sai |
| 5 | 4 | Sai |
| 6 | 3 | Sai |
| 7 | 2 | Sai |
| 8 | 1 | Sai |
| 9 | (i > n − 1, thoát vòng lặp) | Sai |

Kết quả xuất: **Không nguyên tố** (9 = 3 × 3).

### n = 1

| n | n < 2 ? | Kết quả xuất |
|---|---------|--------------|
| 1 | Đúng | Không nguyên tố |

Chương trình không vào vòng lặp. Kết quả: **Không nguyên tố** (1 không lớn hơn 1).

### Tổng hợp

| n | Nhánh đi qua | Kết quả | Đúng như dự kiến? |
|---|--------------|---------|-------------------|
| 7 | n ≥ 2, không có ước | Nguyên tố | Đúng |
| 9 | n ≥ 2, tìm thấy ước 3 | Không nguyên tố | Đúng |
| 1 | n < 2 | Không nguyên tố | Đúng |

Ba bộ dữ liệu đi qua đủ ba nhánh: `n < 2`, `laNT` còn Đúng, `laNT` thành Sai.

---

## 7. Cải tiến (tính hiệu quả): chỉ thử khi i * i ≤ n

### Mã giả cải tiến

```
BẮT ĐẦU
  NHẬP n
  NẾU n < 2 THÌ
    XUẤT "Không nguyên tố"
  NGƯỢC LẠI
    laNT ← Đúng
    i ← 2
    TRONG KHI i * i ≤ n
      NẾU n % i = 0 THÌ
        laNT ← Sai
      KẾT THÚC NẾU
      i ← i + 1
    KẾT THÚC TRONG KHI
    NẾU laNT = Đúng THÌ
      XUẤT "Nguyên tố"
    NGƯỢC LẠI
      XUẤT "Không nguyên tố"
    KẾT THÚC NẾU
  KẾT THÚC NẾU
KẾT THÚC
```

### Lưu đồ cải tiến

![Lưu đồ cải tiến](images/Buoi01_B7_luudocaitien.png)

### Vì sao chỉ cần thử i khi i * i ≤ n?

Nếu `n` là hợp số thì `n = a × b` với `1 < a ≤ b < n`. Nếu cả hai ước đều lớn hơn √n thì `a × b > √n × √n = n`, vô lý. Vậy **ít nhất một trong hai ước phải ≤ √n**. Tức là nếu n có ước nào khác 1 và n thì chắc chắn có ước `i` thỏa `2 ≤ i ≤ √n`, tương đương `i * i ≤ n`. Các số `i` lớn hơn √n không cần thử nữa. Viết `i * i ≤ n` thay cho `i ≤ √n` để tránh phép căn và số thực.

### Chạy tay cải tiến

| n | i | i * i ≤ n ? | n % i | laNT | Kết quả |
|---|---|-------------|-------|------|---------|
| 7 | 2 | 4 ≤ 7 đúng | 1 | Đúng | |
| 7 | 3 | 9 ≤ 7 sai, thoát | | Đúng | **Nguyên tố** |
| 9 | 2 | 4 ≤ 9 đúng | 1 | Đúng | |
| 9 | 3 | 9 ≤ 9 đúng | 0 | Sai | |
| 9 | 4 | 16 ≤ 9 sai, thoát | | Sai | **Không nguyên tố** |
| 1 | | n < 2 đúng | | | **Không nguyên tố** |

Kết quả giống cách cơ bản, nhưng số lần thử ít hơn (n = 9: 2 lần thay vì 7 lần; n = 7: 2 lần thay vì 5 lần).

### Với n = 97: số lần thử giảm từ 95 xuống còn bao nhiêu?

- **Cách cơ bản:** i chạy từ 2 đến 96, gồm 96 − 2 + 1 = **95** lần thử.
- **Cách cải tiến:** điều kiện `i * i ≤ 97`. Ta có 9 × 9 = 81 ≤ 97 nhưng 10 × 10 = 100 > 97, nên i chạy từ 2 đến 9, gồm 9 − 2 + 1 = **8** lần thử.

Số lần thử giảm từ 95 xuống còn **8** (97 là số nguyên tố, vì không có i nào trong 2..9 chia hết 97).

> Cải tiến thêm (không bắt buộc): khi tìm được ước thì có thể thoát vòng lặp ngay thay vì tiếp tục thử, vì kết quả đã chắc chắn là "Không nguyên tố".
