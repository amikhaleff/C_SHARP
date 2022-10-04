string words=System.Console.ReadLine()??"0"; 
System.Console.WriteLine(words);
string[]nums=words.Split(","); // создаем массив. Split убирает знак, указанный в кавычках
int index=new Random().Next(0,nums.Length); // рандомно выбирает индекс в заданном диапазоне
System.Console.WriteLine(nums[index]);
System.Console.WriteLine(string.Join(" .",nums));// выводит массив(nums) через знак указанный в кавычках
                            