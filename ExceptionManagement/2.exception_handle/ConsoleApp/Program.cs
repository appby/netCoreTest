// Exception Handling

            try
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("b: ");
                int b = int.Parse(Console.ReadLine());  

                var sonuc = a / b;

                Console.WriteLine("{0} / {1} = {2}",a,b,sonuc);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("b sıfır olamaz");
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Sayısal bilgi girmelisiniz.");
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("bir hata oluştu.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally bloğu çalıştı.");
            }