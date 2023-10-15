using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public   class exercise19
   {
       static void Main(string[] args)
    {
    string notes;
    char grd;
          Console.Write("\n\n");
           Console.Write("Notification Channel Parser:\n");
           Console.Write("---------------------------------------------------");
           Console.Write("\n\n");

 
    Console.Write("Input the notification channels :");
    grd = Convert.ToChar(Console.ReadLine().ToUpper());

    switch(grd)
    {
    case 'B':
        notes= " Receive channels: BE, FE, Urgent";
        break;
    case 'F':
       notes= " Receive channels: BE, FE, Urgent";
        break;
    case 'U':
        notes= " Receive channels: BE, FE, Urgent ";
        break;
    case 'H':
        notes= " Receive channels: BE, QA, Urgent";
        break;
    case 'Q':
        notes= " Receive channels: BE, QA, Urgent ";
        break;
    default :
        notes= "Invalid notification Found.";
        break;
    }
    Console.Write("You have chosen  : {0}\n", notes);
} 
}
