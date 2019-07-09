﻿using System;
using System.IO;

namespace CURSO_CSHARP_NELIO_ALVES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in Date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out Date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after Check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");
                
                Console.Write("Check-in Date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out Date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkin, checkout);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation Updated: " + reservation);
                }
            }
        }
    }
}