using System;
using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BaitapOperators_and_Control_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Slide9_1();
            Slide9_2();
            Slide9_3();
            Slide9_4();
            Slide9_5();
            Slide21_1();
            Slide21_2();
            Slide21_3();
            Slide22_1();
            Slide22_2();
            Slide22_3();
            Slide22_4();
            Slide22_5();
            Slide22_6();
            Slide22_7();
            Slide22_8();
        }
        static void Slide9_1()
        {
            Console.WriteLine("Bai tap 1 Slide 9");
            Console.Write("Nhap so thu nhat: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chon phep toan (+, -, *, /): ");
            string dk = Console.ReadLine();
            double kq = 0;
            switch (dk)
            {
                case "+":
                    kq = num1 + num2;
                    Console.WriteLine($"Ket qua: {num1}{dk}{num2} = {kq} ");

                    break;
                case "-":
                    kq = num1 - num2;
                    Console.WriteLine($"Ket qua: {num1}{dk}{num2} = {kq} ");

                    break;
                case "*":
                    kq = num1 * num2;
                    Console.WriteLine($"Ket qua: {num1}{dk}{num2} = {kq} ");

                    break;
                case "/":
                    kq = num1 / num2;
                    Console.WriteLine($"Ket qua: {num1}{dk}{num2} = {kq} ");

                    break;
                default:
                    Console.WriteLine("Loi: Phep toan khong hop le: ");
                    break;

            }
            Console.WriteLine();
        }
        static void Slide9_2()
        {
            Console.WriteLine("Bai tap 2 Slide 9");
            Console.WriteLine("y\t x = y^2 + 2y + 1");
            Console.WriteLine("------------------------");

            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"{y}\t {x}");
            }
            Console.WriteLine();
        }
        static void Slide9_3()
        {
            Console.WriteLine("Bai tap 3 Slide 9");
            // Nhập quãng đường (km)
            Console.Write("Nhập quãng đường (km): ");
            double distanceKm = Convert.ToDouble(Console.ReadLine());

            // Nhập thời gian (giờ, phút, giây)
            Console.Write("Nhập số giờ: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số phút: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số giây: ");
            int seconds = Convert.ToInt32(Console.ReadLine());

            // Đổi thời gian sang giờ
            double timeHours = hours + (minutes / 60.0) + (seconds / 3600.0);

            // Tính vận tốc
            double speedKmh = distanceKm / timeHours;
            double speedMph = speedKmh * 0.621371; // đổi từ km/h sang miles/h

            // Xuất kết quả
            Console.WriteLine("\n--- Kết quả ---");
            Console.WriteLine($"Vận tốc: {speedKmh:F2} km/h");
            Console.WriteLine($"Vận tốc: {speedMph:F2} miles/h");
            Console.WriteLine();
        }
        static void Slide9_4()
        {
            Console.WriteLine("Bai tap 4 Slide 9");
            // Nhập bán kính
            Console.Write("Nhập bán kính hình cầu (r): ");
            double r = Convert.ToDouble(Console.ReadLine());

            // Tính diện tích và thể tích
            double surface = 4 * Math.PI * Math.Pow(r, 2);      // S = 4πr^2
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(r, 3); // V = 4/3 πr^3

            // Xuất kết quả
            Console.WriteLine($"\n--- Kết quả ---");
            Console.WriteLine($"Diện tích mặt cầu: {surface:F2}");
            Console.WriteLine($"Thể tích hình cầu: {volume:F2}");
            Console.WriteLine();
        }
        static void Slide9_5()
        {
            Console.WriteLine("Bai tap 5 Slide 9");
            // Nhập ký tự
            Console.Write("Nhập một ký tự: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Kiểm tra nguyên âm
            if ("aeiouAEIOU".IndexOf(ch) >= 0)
            {
                Console.WriteLine($"{ch} là nguyên âm.");
            }
            // Kiểm tra chữ số
            else if (char.IsDigit(ch))
            {
                Console.WriteLine($"{ch} là chữ số.");
            }
            // Các ký tự khác
            else
            {
                Console.WriteLine($"{ch} là ký hiệu khác.");
            }
            Console.WriteLine();
        }
        static void Slide21_1()
        {
            Console.WriteLine("Bai tap 1 Slide 21");
            Console.Write("Nhập một số: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Kiểm tra chẵn/lẻ
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{number} là số lẻ.");
            }
            Console.WriteLine();
        }
        static void Slide21_2()
        {
            Console.WriteLine("Bai tap 2 Slide 21");
            // Nhập 3 số
            Console.Write("Nhập số thứ nhất: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số thứ ba: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Tìm số lớn nhất
            int largest = a;

            if (b > largest)
                largest = b;

            if (c > largest)
                largest = c;
            // Xuất kết quả
            Console.Write($"\nSố lớn nhất là: {largest}");
            Console.WriteLine();
        }
        static void Slide21_3()
        {
            Console.WriteLine("Bai tap 3 Slide 21");
            // Nhập tọa độ
            Console.Write("Nhập giá trị X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập giá trị Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra vị trí
            if (x > 0 && y > 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trong góc phần tư thứ 1.");
            else if (x < 0 && y > 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trong góc phần tư thứ 2.");
            else if (x < 0 && y < 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trong góc phần tư thứ 3.");
            else if (x > 0 && y < 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trong góc phần tư thứ 4.");
            else if (x == 0 && y == 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm tại gốc tọa độ (origin).");
            else if (x == 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục Y.");
            else if (y == 0)
                Console.WriteLine($"Điểm ({x}, {y}) nằm trên trục X.");
            Console.WriteLine();
        }
        static void Slide22_1()
        {
            Console.WriteLine("Bai tap 1 Slide 22");
            // Nhập 3 cạnh
            Console.Write("Nhập cạnh a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            // Kiểm tra có phải là tam giác hợp lệ
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Đây là tam giác đều (Equilateral).");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Đây là tam giác cân (Isosceles).");
                else
                    Console.WriteLine("Đây là tam giác thường (Scalene).");
            }
            else
            {
                Console.WriteLine("Ba cạnh này không tạo thành tam giác hợp lệ.");
            }
            Console.WriteLine();
        }

        static void Slide22_2()
        {
            Console.WriteLine("Bai tap 2 Slide 22");
            int n = 10;
            int sum = 0;

            Console.WriteLine($"Nhập {n} số nguyên:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Số thứ {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }

            double average = (double)sum / n;

            Console.WriteLine($"Tổng của {n} số là: {sum}");
            Console.WriteLine($"Trung bình cộng của {n} số là: {average}");
            Console.WriteLine();
        }
        static void Slide22_3()
        {
            Console.WriteLine("Bai tap 3 Slide 22");
            Console.Write("Nhập một số nguyên để in bảng cửu chương: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nBảng cửu chương của {n}:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
            Console.WriteLine();
        }
        static void Slide22_4()
        {
            Console.WriteLine("Bai tap 4 Slide 22");
            Console.Write("Nhập số hàng của tam giác: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHình tam giác bằng số:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Slide22_5()
        {
            Console.WriteLine("Bai tap 5 Slide 22");
            Console.Write("n = "); int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Pattern A:");
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(j);
                Console.WriteLine();
            }

            Console.WriteLine("Pattern B:");
            int val = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write($"{val++} ");
                Console.WriteLine();
            }

            Console.WriteLine("Pattern C:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', 2 * (n - i)));
                for (int j = 1; j <= i; j++) Console.Write($"{j} ");
                Console.WriteLine();

            }
        }
        static void Slide22_6()
        {
            Console.WriteLine("Bai tap 6 Slide 22");
            Console.Write("n = "); int n = int.Parse(Console.ReadLine()!);
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write(i == 1 ? "1" : $" + 1/{i}");
            }
            Console.WriteLine($"\nTổng = {sum}");
            Console.WriteLine();
        }
        static void Slide22_7()
        {
            Console.WriteLine("Bai tap 7 Slide 22");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số bắt đầu: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số kết thúc: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\nCác số hoàn hảo trong khoảng {start} đến {end}:");

            for (int num = start; num <= end; num++)
            {
                if (IsPerfect(num))
                {
                    Console.Write(num);
                }
            }
            Console.WriteLine();
        }

        // Hàm kiểm tra số hoàn hảo
        static bool IsPerfect(int n)
        {
            if (n < 2) return false;
            int sum = 1; // 1 luôn là ước của mọi số
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum == n;
            Console.WriteLine();
        }
        static void Slide22_8()
        {
            Console.WriteLine("Bai tap 8 Slide 22");
            Console.Write("Nhập một số nguyên: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(n))
                Console.WriteLine($"{n} là số nguyên tố.");
            else
                Console.WriteLine($"{n} không phải là số nguyên tố.");
            Console.WriteLine();
        }

        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}


