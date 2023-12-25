//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
       char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'},
        };

        string result = "";

        // Создаем строку из символов массива
        for (int i = 0; i < charArray.GetLength(0); i++)
        {
            for (int j = 0; j < charArray.GetLength(1); j++)
            {
                result += charArray[i, j];
            }
        }

        // Выводим строку на экран
        Console.WriteLine(result);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.

 //       string inputString = "“aBcD1ef!DUY-";
 //       string resultString = "";

 //       foreach (char c in inputString)
//        {
 //           if (Char.IsUpper(c))
 //           {
 //               resultString += Char.ToLower(c);
 //           }
 //           else
 //           {
  //              resultString += c;
  //          }
 //       }

  //      Console.WriteLine(resultString);

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
//string inputString = "aBcD1ef!-";
        
//        char[] charArray = inputString.ToLower().ToCharArray();
 //       Array.Reverse(charArray);
 //       string reversedString = new string(charArray);

 //       if (inputString.ToLower() == reversedString)
 //       {
 //           Console.WriteLine("Строка является палиндромом");
//        }
//        else
//        {
 //           Console.WriteLine("Строка не является палиндромом");
//        }

//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
//Сформировать строку, в которой слова расположены в обратном порядке. 
//В полученной строке слова должны быть также разделены пробелами.

//        string inputString = "Hello my world";
        
 //       char[] delimiter = { ' ' };
 //       string[] words = inputString.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

//        Array.Reverse(words);
 //       string reversedString = String.Join(" ", words);

//        Console.WriteLine(reversedString);


    



        
    




    


