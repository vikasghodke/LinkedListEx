using System;
using System.Collections.Generic;

namespace DataStructureExample
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("Enter the operations for linked list:\nInsert data->1 \nInset First Node->2 \nInsert Last Node->3 \nInsert Mid->4 \n Remove First->5 \nRemove Last->6 \nRemove Mid->7 \nDiesplay->8");

            LinkedList<int> n1 = new LinkedList<int>();




            int choice = 0;
            while (choice != 9)
            {
                Console.WriteLine("enter choice :");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("enter 1 data: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    n1.insert(data);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("enter 2 data: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    n1.InsertFirst(data);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("enter data: ");
                    int data = Convert.ToInt32(Console.ReadLine());
                    n1.InertLast(data);
                }
                else if (choice == 4)
                {
                    n1.InsertMid(78);
                }
                else if (choice == 5)
                {
                    n1.RemoveFirst();
                }
                else if (choice == 6)
                {
                    n1.RemoveLast();
                }
                else if (choice == 7)
                {
                    n1.RemoveMid();
                }
                else if (choice == 8)
                {
                    n1.Display();
                }




            }







        }
    }
}
