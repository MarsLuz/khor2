using System;

class MainClass {
  public static void Main (string[] args) {
    // รับค่าจำนวนจริงบวก 3 ค่า และยอดชำระในใบเสร็จหรือใบสำคัญรับเงินแต่ละใบ
    Console.Write("Enter balance 1: ");
    double B1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter balance 2: ");
    double B2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter balance 3: ");
    double B3 = Convert.ToDouble(Console.ReadLine());
    double L = 0.0;

    // หักยอดชำระจากยอดเบ็ดเตล็ดที่ 1 จนกว่าจะหมด หากยอดเบ็ดเตล็ดที่ 1 เหลือไม่เพียงพอ หักจากยอดเบ็ดเตล็ดที่ 2 แทน หากยอดเบ็ดเตล็ดที่ 2 ก็เหลือไม่เพียงพอเช่นกัน หักจากยอดเบ็ดเตล็ดที่ 3 แทน
    while (true) {
      Console.Write("Enter payment amount (enter 0 or negative number to exit): ");
      double payment = Convert.ToDouble(Console.ReadLine());
      if (payment <= 0.0) {
        break;
      }

      if (B1 >= payment) {
        B1 -= payment;
      } else if (B2 >= payment - B1) {
        B2 -= payment - B1;
        B1 = 0.0;
      } else if (B3 >= payment - B1 - B2) {
        B3 -= payment - B1 - B2;
        B2 = 0.0;
        B1 = 0.0;
      } else {
        L += payment - B1 - B2 - B3;
        B3 = 0.0;
        B2 = 0.0;
        B1 = 0.0;
      }
    }

    // แสดงผลลัพธ์
    Console.WriteLine($"Balance 1: {B1}");
    Console.WriteLine($"Balance 2: {B2}");
    Console.WriteLine($"Balance 3: {B3}");
    if (L > 0.0) {
      Console.WriteLine($"Left: {L}");
    }
  }
}
