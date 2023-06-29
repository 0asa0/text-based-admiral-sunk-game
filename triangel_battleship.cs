using System;

namespace TRIANGLE__BATTLESHIP
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double a = 0;
            double b = 0;
            double c = 0;
            double area = 0;
            int x1 = 0;
            int x2 = 0;
            int x3 = 0;
            int y1 = 0;
            int y2 = 0;
            int y3 = 0;

            //a, b, c are sides of triangle
            do
            {
                Console.WriteLine("***** TRIANGLE BATTLESHIP GAME *****");
                Console.WriteLine("Please Press 1 To Entering The Ship's Position ");
                Console.WriteLine("Please Press 2 To Listing The Properties Of The Ship ");
                Console.WriteLine("Please Press 3 To Shooting At The Ship");
                Console.WriteLine("Please Press 4 To Showing High Score Table ");
                Console.WriteLine("Please Press 5 To Exit ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {


                    Console.WriteLine("Please enter A(x1,y1), B(x2,y2), C(x3,y3)");
                    Console.WriteLine("X values must be between 0 and 30 and y values must be between 0 and 12.");


                    Console.WriteLine("x1: ");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    if (x1 <= 30 & x1 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The x values must be greater than or equal to 0 and less than or equal to 30. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;

                    }

                    Console.WriteLine("y1: ");
                    y1 = Convert.ToInt32(Console.ReadLine());
                    if (y1 <= 12 & y1 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The y values must be greater than or equal to 0 and less than or equal to 12. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;


                    }

                    Console.WriteLine("x2: ");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    if (x2 <= 30 & x2 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The x values must be greater than or equal to 0 and less than or equal to 30. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;


                    }

                    Console.WriteLine("y2: ");
                    y2 = Convert.ToInt32(Console.ReadLine());
                    if (y2 <= 12 & y2 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The y values must be greater than or equal to 0 and less than or equal to 12. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;


                    }

                    Console.WriteLine("x3: ");
                    x3 = Convert.ToInt32(Console.ReadLine());
                    if (x3 <= 30 & x3 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The x values must be greater than or equal to 0 and less than or equal to 30. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;

                    }

                    Console.WriteLine("y3: ");
                    y3 = Convert.ToInt32(Console.ReadLine());
                    if (y3 <= 12 & y3 >= 0)
                        Console.WriteLine(" ");
                    else
                    {
                        Console.WriteLine("The y values must be greater than or equal to 0 and less than or equal to 12. Please restart the game and make sure you entered the correct values.");
                        Console.ReadKey(true);
                        Console.Clear();
                        continue;

                    }

                    Console.WriteLine("System checking if the coordinates you entered form a triangle...");
                    a = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                    b = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));
                    c = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

                    if ((Math.Abs(b - c) < a) & (a < (b + c)))
                        Console.WriteLine("Side a checked.");

                    else
                    {
                        Console.WriteLine("In order for the entered values to form a triangle, side a must be greater than the difference of sides b and c and, less than the sum.");
                        break;
                    }

                    if ((Math.Abs(a - c) < b) & (b < (a + c)))
                        Console.WriteLine("Side b checked.");

                    else
                    {
                        Console.WriteLine("In order for the entered values to form a triangle, side b must be greater than the difference of sides a and c and, less than the sum.");
                        break;


                    }

                    if ((Math.Abs(a - b) < c) & (c < (a + b)))
                    {
                        Console.WriteLine("Side c checked.");
                        Console.WriteLine("Formed a triangle.");
                        Console.WriteLine(" ");

                        Console.WriteLine("Points A, B, C are transferred to the coordinate plane.");




                        Console.WriteLine("12| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine("11| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine("10| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 9| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 8| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 7| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 6| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 5| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 4| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 3| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 2| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 1| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.Write(" 0+");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 1 1 1 1 1 1 1 1 1 1 2 2 2 2 2 2 2 2 2 2 3");
                        Console.WriteLine("                      0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetWindowSize(95, 50);
                        Console.SetBufferSize(100, 100);
                        Console.SetCursorPosition((2 * x1) + 2, (34 + (12 - y1)));
                        Console.WriteLine("A");

                        Console.SetCursorPosition((2 * x2) + 2, (34 + (12 - y2)));
                        Console.WriteLine("B");


                        Console.SetCursorPosition((2 * x3) + 2, (34 + (12 - y3)));
                        Console.WriteLine("C");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(1, 50);
                        Console.WriteLine("Please type a key to continue.");
                        Console.ReadKey(true);
                        Console.Clear();

                        Console.WriteLine("***** TRIANGLE BATTLESHIP GAME *****");
                        Console.WriteLine("Please Press 2 To Listing The Properties Of The Ship ");
                        Console.WriteLine("Please Press 3 To Shooting At The Ship");
                        Console.WriteLine("Please Press 4 To Showing High Score Table ");
                        Console.WriteLine("Please Press 5 To Exit ");
                        choice = Convert.ToInt32(Console.ReadLine());

                    }

                    else
                    {
                        Console.WriteLine("In order for the entered values to form a triangle, side c must be greater than the difference of sides a and b and, less than the sum.");
                        break;

                    }

                }

                if (choice == 2)
                {


                    Console.WriteLine("**Properties Of The Ship**");

                    if (a != 0 & b != 0 & c != 0)
                    {
                        Console.WriteLine("The size of the ship: " + " a= " + a + " b= " + b + " c= " + c);
                        Console.WriteLine("The perimeter of the ship: " + (a + b + c));

                        double u, medax, meday, medbx, medby, medcx, medcy;
                        u = ((a + b + c) / 2);
                        area = Math.Sqrt(u * (u - a) * (u - b) * (u - c));
                        Console.WriteLine("The area of the ship: " + area);

                        double cosA, cosB, cosC, As, Bs, Cs, A, B, C;
                        cosA = ((b * b) + (c * c) - (a * a)) / (2 * b * c);
                        cosB = ((a * a) + (c * c) - (b * b)) / (2 * a * c);
                        cosC = ((a * a) + (b * b) - (c * c)) / (2 * a * b);

                        As = Math.Acos(cosA);
                        Bs = Math.Acos(cosB);
                        Cs = Math.Acos(cosC);
                        A = (As * (180 / Math.PI));
                        B = (Bs * (180 / Math.PI));
                        C = (Cs * (180 / Math.PI));

                        Console.WriteLine("The angles of the ship: " + " A= " + A + " B= " + B + " C= " + C);

                        medax = ((x2 + x3) / 2);
                        meday = ((y2 + y3) / 2);
                        medbx = ((x1 + x3) / 2);
                        medby = ((y1 + y3) / 2);
                        medcx = ((x1 + x2) / 2);
                        medcy = ((y1 + y2) / 2);

                        Console.WriteLine("Median point of side a: " + "(" + medax + "," + meday + ")"
                            + " Median point of side b: " + "(" + medbx + "," + medby + ")"
                            + " Median point of side c: " + "(" + medcx + "," + medcy + ")");

                        double centx, centy, k, bis, incir, circir,r;

                        centx = Convert.ToDouble((x1 + x2 + x3) / 3);
                        centy = Convert.ToDouble((y1 + y2 + y3) / 3);

                        Console.WriteLine("The centroid of the ship: " + "(" + centx + "," + centy + ")");
   
                        k = (a / (c + b));
                        bis = Math.Sqrt((b * c) - (b * c * k * k));
                        Console.WriteLine("The length of the bisector of the point A: " + bis);
                        /////////////////////////////////////////////////////////////
                        r = area / u;
                        incir = Math.PI * (r * r);
                        Console.WriteLine("The area of the inscribed circle: " + incir);
                        /////////////////////////////////////////////////////////////

                        circir = Math.PI * ((a * b * c) / (4 * area)) * ((a * b * c) / (4 * area));
                        Console.WriteLine("The area of circumscribed circle: " + circir);


                        /////////////////////////////////////////////////////////////
                        if (A < 90 & B < 90 & C < 90)
                        {
                            Console.WriteLine("The type of the ship: Acute-angled");
                        }
                        else if (A == 90 | B == 90 | C == 90)
                        {
                            Console.WriteLine("The type of the ship: Right-angled");
                        }
                        else if (A > 90 | B > 90 | C > 90)
                        {
                            Console.WriteLine("The type of the ship: Obtuse-angled");
                        }
                        /////////////////////////////////////////////////////////////
                        if (a == b & b == c & a == c)
                        {
                            Console.WriteLine("The type of the ship: Equilateral");
                        }
                        else if (a == b & b != c)
                        {
                            Console.WriteLine("The type of the ship: Isosceles");
                        }
                        else if (b == c & c != a)
                        {
                            Console.WriteLine("The type of the ship: Isosceles");
                        }
                        else if ((a == c & c != b))
                        {
                            Console.WriteLine("The type of the ship: Isosceles");
                        }
                        else
                        {
                            Console.WriteLine("The type of the ship: Scalene");
                        }
                        /////////////////////////////////////////////////////////////

                        Console.WriteLine("Please type a key to continue.");
                        Console.ReadKey(true);
                        Console.Clear();

                        Console.WriteLine(" ");
                        Console.WriteLine("***** TRIANGLE BATTLESHIP GAME ***** ");

                        Console.WriteLine("Please Press 3 To Shooting At The Ship");
                        Console.WriteLine("Please Press 4 To Showing High Score Table ");
                        Console.WriteLine("Please Press 5 To Exit ");
                        choice = Convert.ToInt32(Console.ReadLine());



                    }
                    else
                    {
                        Console.WriteLine("You cannot list the properties of a triangle without creating it. Please first create a triangle from the first option in the menu.");
                        Console.WriteLine("Please type a key to continue.");
                        Console.ReadKey(true);
                        Console.Clear();

                    }


                }
                string name = "";
                double s = 0;

                if (choice == 3)
                {

                    if (a != 0 & b != 0 & c != 0)
                    {
                        Random rand = new Random();

                        int randx, randy;
                        randx = rand.Next(0, 31);
                        randy = rand.Next(0, 13);

                        Console.WriteLine(" ");
                        Console.WriteLine("**Shooting At The Ship**");
                        Console.WriteLine(" ");

                        Console.WriteLine("12| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine("11| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine("10| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 9| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 8| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 7| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 6| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 5| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 4| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 3| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 2| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.WriteLine(" 1| . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
                        Console.Write(" 0+");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 1 1 1 1 1 1 1 1 1 1 2 2 2 2 2 2 2 2 2 2 3");
                        Console.WriteLine("                      0 1 2 3 4 5 6 7 8 9 0 1 2 3 4 5 6 7 8 9 0");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetWindowSize(95, 50);
                        Console.SetBufferSize(100, 100);
                        Console.SetCursorPosition((2 * x1) + 2, (9 + (12 - y1)));
                        Console.WriteLine("A");

                        Console.SetCursorPosition((2 * x2) + 2, (9 + (12 - y2)));
                        Console.WriteLine("B");

                        Console.SetCursorPosition((2 * x3) + 2, (9 + (12 - y3)));
                        Console.WriteLine("C");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition((2 * randx) + 2, (9 + (12 - randy)));
                        Console.WriteLine("X");

                        Console.SetCursorPosition(0, 26);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("A(" + x1 + "," + y1 + ") " + "B(" + x2 + "," + y2 + ") " + "C(" + x3 + "," + y3 + ")");
                        Console.WriteLine("Shooting point: X" + "(" + randx + "," + randy + ")");



                        /*
                        X random point
                        k = |AX|, m=|BX|, n= |CX| 
                        u_xa = Half the sum of the sides m n a, 
                        u_xb = Half the sum of the sides k n b,
                        u_xc = Half the sum of the sides k m c,
                        a_xa = Area of triangle XBC
                        a_xb = Area of triangle AXC
                        a_xc = Area of triangle AXB 
                        */
                        double k, m, n, u_xc, u_xa, u_xb, a_xc, a_xa, a_xb, u;


                        u = ((a + b + c) / 2);
                        area = Math.Sqrt(u * (u - a) * (u - b) * (u - c));

                        k = Math.Sqrt(((randx - x1) * (randx - x1)) + ((randy - y1) * (randy - y1)));
                        m = Math.Sqrt(((randx - x2) * (randx - x2)) + ((randy - y2) * (randy - y2)));
                        n = Math.Sqrt(((randx - x3) * (randx - x3)) + ((randy - y3) * (randy - y3)));
                        u_xc = (k + m + c) / 2;
                        u_xa = (m + n + a) / 2;
                        u_xb = (k + n + b) / 2;

                        a_xc = Math.Sqrt(u_xc * (u_xc - k) * (u_xc - m) * (u_xc - c));
                        a_xa = Math.Sqrt(u_xa * (u_xa - m) * (u_xa - n) * (u_xa - a));
                        a_xb = Math.Sqrt(u_xb * (u_xb - k) * (u_xb - n) * (u_xb - b));
                        s = a_xa + a_xb + a_xc;



                        s = Math.Round(s, 4);
                        area = Math.Round(area, 4);


                        if (s <= area)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Your ship sank. Total score is 0.");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Your ship survived. Total score is: " + area);
                            Console.WriteLine("Please enter your name: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            name = Convert.ToString(Console.ReadLine());

                        }


                        Console.WriteLine(" ");
                        Console.WriteLine("Please type a key to continue.");
                        Console.ReadKey(true);
                        Console.Clear();

                        Console.WriteLine("***** TRIANGLE BATTLESHIP GAME ***** ");
                        Console.WriteLine("Please Press 4 To Showing High Score Table ");
                        Console.WriteLine("Please Press 5 To Exit ");
                        choice = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("You cannot shoot because a triangle is not formed. Please first create a triangle from the first option in the menu.");
                        Console.WriteLine("Please type a key to continue.");
                        Console.ReadKey(true);
                        Console.Clear();

                    }
                }

                if (choice == 4)
                {

                    if (area == 0)
                    {
                        Console.WriteLine("**High Score Table**");
                        Console.WriteLine("");
                        Console.WriteLine("Name              Score");
                        Console.WriteLine("");
                        Console.WriteLine("Nazan Kaya         60");
                        Console.WriteLine("Ali Kurt           30");
                        Console.WriteLine("Sibel Arslan       10");
                    }
                    else
                    {

                        if (s > area)
                        {

                            if (area > 60)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine(name);
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine("Ali Kurt                      30");
                                Console.WriteLine("");
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 4);
                                Console.WriteLine(area);
                            }
                            else if (area == 60)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine(name);
                                Console.WriteLine("Ali Kurt                      30");
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 5);
                                Console.WriteLine("60");
                            }
                            else if (area > 30 & area < 60)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine(name);
                                Console.WriteLine("Ali Kurt                      30");
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 5);
                                Console.WriteLine(area);
                            }
                            else if (area == 30)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine("Ali Kurt                      30");
                                Console.WriteLine(name);
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 6);
                                Console.WriteLine("30");
                            }
                            else if (area > 10 & area < 30)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine("Ali Kurt                      30");
                                Console.WriteLine(name);
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 6);
                                Console.WriteLine(area);
                            }
                            else if (area == 10)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name                         Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya                    60");
                                Console.WriteLine("Ali Kurt                      30");
                                Console.WriteLine("Sibel and " + name);
                                Console.SetWindowSize(95, 50);
                                Console.SetBufferSize(100, 100);
                                Console.SetCursorPosition(30, 6);
                                Console.WriteLine("10");
                            }
                            else if (area < 10)
                            {
                                Console.WriteLine("**High Score Table**");
                                Console.WriteLine("");
                                Console.WriteLine("Name              Score");
                                Console.WriteLine("");
                                Console.WriteLine("Nazan Kaya         60");
                                Console.WriteLine("Ali Kurt           30");
                                Console.WriteLine("Sibel Arslan       10");
                            }

                        }
                        else
                        {
                            Console.WriteLine("**High Score Table**");
                            Console.WriteLine("");
                            Console.WriteLine("Name              Score");
                            Console.WriteLine("");
                            Console.WriteLine("Nazan Kaya         60");
                            Console.WriteLine("Ali Kurt           30");
                            Console.WriteLine("Sibel Arslan       10");
                        }
                    }



                    Console.SetWindowSize(95, 50);
                    Console.SetBufferSize(100, 100);
                    Console.SetCursorPosition(0, 16);
                    Console.WriteLine("You can play again or exit.Please type a key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();

                }

                if (choice == 5)
                {
                    Console.WriteLine("Press any key to close.");


                }
                if (choice <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("WRONG CHOISE ");
                    Console.WriteLine("Please choose one of the numbers 1 ,2 ,3 ,4,5.");
                    Console.WriteLine(" ");
                    Console.ReadKey(true);
                    Console.Clear();

                }
                if (choice > 5)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("WRONG CHOISE ");
                    Console.WriteLine("Please choose one of the numbers 1 ,2 ,3 ,4,5.");
                    Console.WriteLine(" ");
                    Console.ReadKey(true);
                    Console.Clear();

                }
            }



            while (choice != 5);
        }
    }
}
