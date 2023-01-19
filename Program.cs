//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int[] arr = new int[4];
            int x = 0;
            void rand(){
                Random rnd = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <4; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write("{0} ", arr[i]);}}
            void even(){
                foreach(int element in arr)
            {
                
                if (element % 2 == 0)
                {
                    x++;
                    
                }}
            }
            rand();
            even();
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}", x);*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


/*
int[] arr = new int[4];
            int sum = 0;
            void rand(){
                Random rnd = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <4; i++)
            {
                arr[i] = rnd.Next(-999, 999);
                Console.Write("{0} ", arr[i]);}}
            void summ(){
                foreach(int element in arr)
            {
                if (element % 2 != 0)
                {
                    sum += element;
                     }}}
            rand();
            summ();
            Console.WriteLine();
            Console.WriteLine("Сумма нечетных элементов {0}", sum);*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] arr = new double[4];
            
            void rand(){
                Random rnd = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <4; i++)
            {
                arr[i] = rnd.NextDouble() * 100;
                Console.Write("{0} ", arr[i]);}}
            
            void mm(){
             double imin = arr[0], imax = arr[0];
                for ( int i = 0; i < arr.Length; i++) {
                    if (arr[i] > imax)
                        imax = arr[i];
                    if (arr[i] < imin)
                        imin = arr[i]; }
                        double diff = imax - imin;  
                        Console.WriteLine();
             Console.WriteLine("разница между максимальным " + imax + " и минимальным " + imin + " значениями равна " + diff);}
rand();
mm();
            
            
