using System;

namespace Month {
    class MainClass {
        int MonthInput() { 
            string UserInput;
            int month;
            Console.WriteLine("Nhập tháng");
            UserInput = Console.ReadLine();
            month = Convert.ToUInt16(UserInput);

            if(month is int == false || month > 12) {
                Console.WriteLine("+ Giá trị \"{0}\" bạn vừa nhập không phải là số nguyên\n+Hoặc có giá trị lớn hơn 12", month);
                Console.ReadKey();
                return 0;       
            }
            switch(month) {
                case 1:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;
                case 2:
                Console.WriteLine("Tháng {0} có 28 ngày", month);
                Console.ReadKey();
                break;
                case 3:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
                case 4:
                Console.WriteLine("Tháng {0} có 30 ngày", month);
                Console.ReadKey();
                break;                
                case 5:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
                case 6:
                Console.WriteLine("Tháng {0} có 30 ngày", month);
                Console.ReadKey();
                break;                
                case 7:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
                case 8:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
                case 9:
                Console.WriteLine("Tháng {0} có 30 ngày", month);
                Console.ReadKey();
                break;                
                case 10:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
                case 11:
                Console.WriteLine("Tháng {0} có 30 ngày", month);
                Console.ReadKey();
                break;                
                case 12:
                Console.WriteLine("Tháng {0} có 31 ngày", month);
                Console.ReadKey();
                break;                
            }
            return month;           
        }
        static void Main() {
            MainClass MainMethod = new MainClass();
            MainMethod.MonthInput();
        }
    }
}
