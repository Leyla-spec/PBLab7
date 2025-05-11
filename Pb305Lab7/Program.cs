namespace PBLab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 
            
            int[] arr = { -1, 2, -3, 4, -5 };
            int[] result = Arr(arr);
            foreach (int num in result)
            {
                Console.WriteLine(num);
            }
            

            //2 
            
            string s = "enene";
            string c = s.Trim().ToLower();
            Str(c);
            

            //3 
            
            string m = "aabbccddeeffgg";

            Arr2(m);
            

            //4 
            
            string d = "Hello World! How are you?";
            Str2(d);
            

            //5
            
            string str = "salam necesen";
            Str3(str);
            

            //6
            
            string email = "test@code.edu.az";
            Str4(email);
            

            //7
            
            string str5 = "Hello123";

            bool isOnlyLetters = true;
            Str5(str5);
            

            //8
            
            string str6 = "saLAm nEceSen";
            Str6(str6);
            

            //9
            string[] fullNames = { "Cabbarli Gulnar", "Eliyev Eli"};
            Str7(fullNames);
        }   


        //1. int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə
        //bir method yazın ki, bu array-i parametr olaraq qəbul etsin və qəbul
        //etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra
        //içindəki mənfi ədədləri müsbətə çevirib həmin array-i geriyə qaytarsın
        
        public static int[] Arr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = -arr[i];
                }
            }
            return arr;
        }
        

        //2. Verilmiş stringin Palindrome olub olmamağını yoxlayın.
        
        public static void Str(string s )
        {
            bool isPalindrome = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }
            Console.WriteLine(isPalindrome);
        }


        //3. Verilmiş stringin içərisindəki təkrarlanan karakterləri silin.
        
        public static void Arr2(string m)
        {
            for (int i = 0; i < m.Length; i++) { 

                int count = 0;

                for (int j = i + 1; j < m.Length; j++)
                {
                    if (m.IndexOf(m[i]) == m.IndexOf(m[j]))
                    {
                        count++;
                    }

                }
                if (count == 1)

                    Console.Write(m[i]);
            }
        }
        

        //4. Verilmiş string bir mətnin içərisindəki boşluqlara qədər olan sözdəri
        //ayrılıqda yazın.
        
        public static void Str2(string d)
        {
            string[] f = d.Split(' ');

            foreach (string s in f)
            {
                Console.WriteLine(s);
            }
        }
  

        //5. Verilmiş strigin ilk 4 hərfini ekrana yazdırın.
       
        public static void Str3(string str)
        {
            if (str.Length >= 4)
            {
                string firstFourChars = str.Substring(0, 4);
                Console.WriteLine(firstFourChars);
            }
            else
            {
                Console.WriteLine("Stringin uzunluğu 4-dən azdır.");
            }
        }
        

        //6. Verilmiş email dəyərinin domain hissəni qaytaran metod
        //(test@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)
        
        public static void Str4(string email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex != -1 && atIndex < email.Length - 1)
            {
                string domain = email.Substring(atIndex + 1);
                Console.WriteLine(domain);
            }
            else
            {
                Console.WriteLine("Düzgün email formatı deyil.");
            }
        }
      

        //7. Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod
        
        public static void Str5(string str5)
        {
            bool isOnlyLetters = true;
            char[] arr = str5.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= '0' && arr[i] <= '9')
                {
                    isOnlyLetters = false;
                }

            }
            Console.WriteLine(isOnlyLetters);
        }
       
 
        //8. Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran
        //metod(Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan
        //"Salam necesen" return olmalıdır)
        
        public static void Str6(string str6)
        {
            if (string.IsNullOrEmpty(str6))
            {
                Console.WriteLine(str6); 
            }
            string firstLetter = str6.Substring(0, 1).ToUpper();
            string remainingLetters = str6.Substring(1).ToLower();
            Console.WriteLine(firstLetter + remainingLetters);


        }
        

        //9. Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
        //(ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)

        public static void Str7(string[] fullNames)
        {
            string[] names = new string[fullNames.Length];

            for (int i = 0; i < fullNames.Length; i++)
            {
                string[] parts = fullNames[i].Split(' ');
                if (parts.Length >1)
                {
                    names[i] = parts[1];
                }
                else
                {
                    names[i] = "";
                }
               
            }
            foreach (string name in names) {
                Console.WriteLine(name);
            }
            
        }
    }
}




