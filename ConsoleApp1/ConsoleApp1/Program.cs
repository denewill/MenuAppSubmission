using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //INITIALIZING. NAMES CREATED CAN BE CHANGED
            Restaurant _Restaurant = Restaurant.GetRestaurant;
            Owner _Owner1 = new Owner(1, "Ten");
            Customer _Customer1 = new Customer("Hoon", 1);
            PaymentMethod _PaymentMethod1 = new Cash();
            PaymentMethod _PaymentMethod2 = new Card();
            PaymentMethod _PaymentMethod3 = new Cheque();
            _Owner1.CreateWaiter(1, "Yoon", "0123456789");
            _Owner1.CreateChef(2, "Mino", "0012345678");
            _Owner1.CreateItem(1, "Spaghetti Oglio Olio", "A garlic based pasta served with garlic bread", 7.5);
            _Owner1.CreateItem(2, "New York Style Pizza", "A 16 inch pepperoni pizza. Great for sharing!", 18.5);
            _Owner1.CreateItem(3, "Flat White", "A local favourite! Milk coffee with light cocoa powder sprinkle.", 3.5);
            _Owner1.CreateInStoreMenu(1);
            _Owner1.AddItemstoMenu(_Owner1.GetItem(1), 1);
            _Owner1.AddItemstoMenu(_Owner1.GetItem(2), 1);
            _Owner1.AddItemstoMenu(_Owner1.GetItem(3), 1);
            _Owner1.CreateTakeawayMenu(2);
            _Owner1.AddItemstoMenu(_Owner1.GetItem(3), 2);
                
            Console.Clear();

            //SHOW MAIN MENU
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("1. Owner");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Choose an interface:  [eg. INPUT 0, 1, 2, or 3]");

                switch (Console.ReadLine())
                {
                    case "0":
                        showMenu = false;
                        break;

                    case "1":

                        //OWNER MENU

                        bool showOwnerMenu = true;
                        while (showOwnerMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("======== OWNER MENU ========");
                            Console.WriteLine("1. Staff Management");
                            Console.WriteLine("2. Item Management");
                            Console.WriteLine("3. Menu Management");
                            Console.WriteLine("4. Review Report");
                            Console.WriteLine("0. Exit to Main Menu");
                            switch (Console.ReadLine())
                            {
                                case "0":
                                    showOwnerMenu = false;
                                    break;

                                case "1":
                                    // OWNER STAFF MENU 

                                    bool showOwnerStaffMenu = true;
                                    while (showOwnerStaffMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("======== OWNER STAFF MENU ========");
                                        Console.WriteLine("1. Create Waiter");
                                        Console.WriteLine("2. Create Chef");
                                        Console.WriteLine("3. Update Staff Details ");
                                        Console.WriteLine("4. Delete Staff");
                                        Console.WriteLine("0. Exit to Owner Menu");
                                        switch (Console.ReadLine())
                                        {
                                            case "0":
                                                showOwnerStaffMenu = false;
                                                break;

                                            case "1":
                                                Console.Write("Input Staff ID: ");
                                                int StaffID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input Staff Name: ");
                                                string StaffName = Console.ReadLine();
                                                Console.Write("Input Staff Phone Number: ");
                                                string StaffPhone = Console.ReadLine();
                                                Console.WriteLine(_Owner1.CreateWaiter(StaffID, StaffName, StaffPhone));
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.Write("Input Staff ID: ");
                                                StaffID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input Staff Name: ");
                                                StaffName = Console.ReadLine();
                                                Console.Write("Input Staff Phone Number: ");
                                                StaffPhone = Console.ReadLine();
                                                Console.WriteLine(_Owner1.CreateChef(StaffID, StaffName, StaffPhone));
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Write("Input Old Staff ID: ");
                                                int OldStaffID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input New Staff ID: ");
                                                int NewStaffID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input New Staff Name: ");
                                                string NewStaffName = Console.ReadLine();
                                                Console.Write("Input New Staff Phone Number: ");
                                                string NewStaffPhone = Console.ReadLine();
                                                Console.WriteLine(_Owner1.ChangeStaff(OldStaffID, NewStaffID, NewStaffName, NewStaffPhone));
                                                Console.ReadKey();
                                                break;

                                            case "4":
                                                Console.Write("Input Staff ID: ");
                                                StaffID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.DeleteStaff(StaffID));
                                                Console.ReadKey();
                                                break;

                                            default:
                                                break;
                                        }
                                    }
                                    break;

                                case "2":
                                    // OWNER ITEM MENU

                                    bool showOwnerItemMenu = true;
                                    while (showOwnerItemMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("======== OWNER ITEM MENU ========");
                                        Console.WriteLine("1. Create Item");
                                        Console.WriteLine("2. Change Item");
                                        Console.WriteLine("3. Delete Item");
                                        Console.WriteLine("0. Exit to Owner Menu");
                                        switch (Console.ReadLine())
                                        {
                                            case "0":
                                                showOwnerItemMenu = false;
                                                break;
                                            case "1":
                                                Console.Write("Input Item ID: ");
                                                int ItemID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input Item Name: ");
                                                string ItemName = Console.ReadLine();
                                                Console.Write("Input Item Detail: ");
                                                string ItemDetail = Console.ReadLine();
                                                Console.Write("Input Item Price: ");
                                                double ItemPrice = double.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.CreateItem(ItemID, ItemName, ItemDetail, ItemPrice));
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.Write("Input Old Item ID: ");
                                                int OldItemID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input New Item ID: ");
                                                int NewItemID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input New Item Name: ");
                                                string NewItemName = Console.ReadLine();
                                                Console.Write("Input New Item Detail: ");
                                                string NewItemDetail = Console.ReadLine();
                                                Console.Write("Input New Item Price: ");
                                                double NewItemPrice = double.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.ChangeItem(OldItemID, NewItemID, NewItemName, NewItemDetail, NewItemPrice));
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Write("Input Item ID: ");
                                                ItemID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.DeleteItem(ItemID));
                                                Console.ReadKey();
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option. Please choose the options available.");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    break;

                                case "3":
                                    //OWNER MENU MENU

                                    bool showOwnerMenuMenu = true;
                                    while (showOwnerMenuMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("======== OWNER MENU MENU ========");
                                        Console.WriteLine("1. Create In-Store Menu");
                                        Console.WriteLine("2. Create Takeaway Menu");
                                        Console.WriteLine("3. Delete Menu");
                                        Console.WriteLine("4. Add Items to Menu");
                                        Console.WriteLine("5. Remove Item from Menu");
                                        Console.WriteLine("0. Exit to Owner Menu");
                                        switch (Console.ReadLine())
                                        {
                                            case "0":
                                                showOwnerMenuMenu = false;
                                                break;

                                            case "1":
                                                Console.Write("Input Menu ID: ");
                                                int MenuID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.CreateInStoreMenu(MenuID));
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.Write("Input Menu ID: ");
                                                MenuID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.CreateTakeawayMenu(MenuID));
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Write("Input Menu ID to be deleted: ");
                                                MenuID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.DeleteMenu(MenuID));
                                                Console.ReadKey();
                                                break;

                                            case "4":
                                                Console.Write("Input Item ID to be added onto the menu: ");
                                                int ItemID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input the Menu ID: ");
                                                MenuID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.AddItemstoMenu(_Owner1.GetItem(ItemID), MenuID));
                                                Console.ReadKey();
                                                break;


                                            case "5":
                                                Console.Write("Input Item ID to be removed from the menu: ");
                                                ItemID = Int32.Parse(Console.ReadLine());
                                                Console.Write("Input the Menu ID: ");
                                                MenuID = Int32.Parse(Console.ReadLine());
                                                Console.WriteLine(_Owner1.DeleteItemFromMenu(ItemID, MenuID));
                                                Console.ReadKey();
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option. Please choose the options available.");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    break;

                                case "4":
                                    //OWNER REPORT REVIEW

                                    Console.WriteLine(_Owner1.ReviewReport());
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Invalid option. Please choose the options available.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;

                    case "2":

                        //STAFF MENU

                        bool showStaffMenu = true;
                        while (showStaffMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("======== STAFF LOGIN ========");
                            Console.WriteLine("Input 0 to return to the Main Menu. \n");
                            Console.Write("Input StaffID: ");
                            string input = Console.ReadLine();
                            if (input == "0")
                            {
                                showStaffMenu = false;
                            }
                            else if (_Owner1.GetStaff(Int32.Parse(input)) == null)
                            {
                                Console.WriteLine("StaffID invalid. Please check your StaffID and try again.");
                                Console.ReadKey();
                            }
                            else 
                            {
                                Staff stafftemp = _Owner1.GetStaff(Int32.Parse(input));

                                if (stafftemp.GetStaffType == "Waiter")
                                {
                                    //WAITER MENU

                                    Waiter waiter = (stafftemp as Waiter);
                                    bool showWaiterMenu = true;
                                    while (showWaiterMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("======== WAITER MENU ========");
                                        Console.WriteLine("1. Order Management");
                                        Console.WriteLine("2. Reservation Managememt");
                                        Console.WriteLine("3. Payment Management");
                                        Console.WriteLine("0. Log Out");
                                        Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");
                                        switch (Console.ReadLine())
                                        {
                                            case "0":
                                                showWaiterMenu = false;
                                                break;

                                            case "1":
                                                //WAITER ORDER RELATED MENU

                                                bool showWaiterOrderMenu = true;
                                                while (showWaiterOrderMenu)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("======== WAITER ORDER MENU ========");
                                                    Console.WriteLine("1. Create Order");
                                                    Console.WriteLine("2. Change Order");
                                                    Console.WriteLine("3. Read Order");
                                                    Console.WriteLine("4. Read All Orders");
                                                    Console.WriteLine("5. Delete Order");
                                                    Console.WriteLine("6. Add Item to Order");
                                                    Console.WriteLine("7. Delete Item from Order");
                                                    Console.WriteLine("8. Deliver Order");
                                                    Console.WriteLine("0. Back to Waiter Menu");
                                                    Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");
                                                    switch (Console.ReadLine())
                                                    {
                                                        case "0":
                                                            showWaiterOrderMenu = false;
                                                            break;

                                                        case "1":
                                                            Console.Write("Input Order ID to created: ");
                                                            int OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input Customer Name: ");
                                                            string CustomerName = Console.ReadLine();
                                                            Console.WriteLine(waiter.CreateOrder(OrderID, CustomerName));
                                                            Console.ReadKey();
                                                            break;

                                                        case "2":
                                                            Console.Write("Input Order ID to be changed: ");
                                                            int OldOrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input New Order ID: ");
                                                            int NewOrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input New Customer Name: ");
                                                            string NewCustomerName = Console.ReadLine();
                                                            Console.WriteLine(waiter.ChangeOrder(OldOrderID, NewOrderID, NewCustomerName));
                                                            Console.ReadKey();
                                                            break;

                                                        case "3":
                                                            Console.Write("Input Order ID to be accessed: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.ReadOrder(OrderID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "4":
                                                            Console.WriteLine(waiter.ReadAllOrders());
                                                            Console.ReadKey();
                                                            break;

                                                        case "5":
                                                            Console.Write("Input Order ID to be deleted: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.DeleteOrder(OrderID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "6":
                                                            Console.Write("Input Order ID to be updated: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input Item ID to be added: ");
                                                            int ItemID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.AddItemsToOrder(OrderID, ItemID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "7":
                                                            Console.Write("Input Order ID to be updated: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input Item ID to be removed: ");
                                                            ItemID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.RemoveItemFromOrder(OrderID, ItemID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "8":
                                                            Console.Write("Input Order ID to be delivered: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.DeliverOrder(OrderID));
                                                            Console.ReadKey();
                                                            break;

                                                        default:
                                                            Console.WriteLine("Invalid option. Please choose the options available.");
                                                            Console.ReadKey();
                                                            break;
                                                    }
                                                }                                                
                                                break;

                                            case "2":
                                                //SHOW RESERVATION RELATED MENU

                                                bool showWaiterReservationMenu = true;
                                                while(showWaiterReservationMenu)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("======== WAITER RESERVATION MENU ========");
                                                    Console.WriteLine("1. Create Reservation");
                                                    Console.WriteLine("2. Change Reservation");
                                                    Console.WriteLine("3. Read Reservation");
                                                    Console.WriteLine("4. Read All Reservations");
                                                    Console.WriteLine("5. Delete Reservation");
                                                    Console.WriteLine("0. Back to Waiter Menu");
                                                    Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");

                                                    switch (Console.ReadLine())
                                                    {                                                        
                                                        case "0":
                                                            showWaiterReservationMenu = false;
                                                            break;

                                                        case "1":
                                                            Console.Write("Input reservation ID: ");
                                                            int ReservationID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input reservation date: ");
                                                            string ReservationDate = Console.ReadLine();
                                                            Console.Write("Input reservation time: ");
                                                            string ReservationTime = Console.ReadLine();
                                                            Console.Write("Input customer name: ");
                                                            string CustomerName = Console.ReadLine();
                                                            Console.Write("Input number of people: ");
                                                            int NumberOfPeople = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.CreateReservation(ReservationID, ReservationDate, ReservationTime, CustomerName, NumberOfPeople));
                                                            _Customer1.GetReservationFromWaiter(waiter.GetReservation(ReservationID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "2":
                                                            Console.Write("Input Reservartion ID to be edited: ");
                                                            int OldReservationID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input new Reservartion ID: ");
                                                            int NewReservationID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input new reservation date: ");
                                                            string NewReservationDate = Console.ReadLine();
                                                            Console.Write("Input new reservation time: ");
                                                            string NewReservationTime = Console.ReadLine();
                                                            Console.Write("Input new customer name: ");
                                                            string NewCustomerName = Console.ReadLine();
                                                            Console.Write("Input new number of people: ");
                                                            int NewNumberOfPeople = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.ChangeReservation(OldReservationID, NewReservationID, NewReservationDate, NewReservationTime, NewCustomerName, NewNumberOfPeople));
                                                            Console.ReadKey();
                                                            break;

                                                        case "3":
                                                            Console.Write("Input Reservartion ID to be accessed: ");
                                                            ReservationID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.ReadReservation(ReservationID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "4":
                                                            Console.WriteLine(waiter.ReadAllReservations());
                                                            Console.ReadKey();
                                                            break;

                                                        case "5":
                                                            Console.Write("Input Reservartion ID to be deleted: ");
                                                            ReservationID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.DeleteReservation(ReservationID));
                                                            Console.ReadKey();
                                                            break;
                                                    }
                                                }
                                                break;

                                            case "3":
                                                //SHOW PAYMENT RELATED MENU

                                                bool showPaymentOrderMenu = true;
                                                while(showPaymentOrderMenu)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("======== WAITER PAYMENT MENU ========");
                                                    Console.WriteLine("1. Create Invoice");
                                                    Console.WriteLine("2. Delete Invoice");
                                                    Console.WriteLine("3. Print Invoice");
                                                    Console.WriteLine("4. Accept Payment");
                                                    Console.WriteLine("0. Back to Waiter Menu");
                                                    Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");

                                                    switch (Console.ReadLine())
                                                    {
                                                        case "0":
                                                            showPaymentOrderMenu = false;
                                                            break;

                                                        case "1":
                                                            Console.Write("Input Order ID to be paid: ");
                                                            int OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input Payment Method [1.CARD  2. CASH  3. CHEQUE]: ");
                                                            PaymentMethod paymethod = null;
                                                            switch (Console.ReadLine())
                                                            {
                                                                case "1":
                                                                    paymethod = new Card();
                                                                    break;
                                                                case "2":
                                                                    paymethod = new Cash();
                                                                    break;
                                                                case "3":
                                                                    paymethod = new Cheque();
                                                                    break;
                                                                default:
                                                                    break;
                                                            }
                                                            Console.WriteLine(waiter.CreateInvoice(OrderID, paymethod));
                                                            Console.ReadKey();
                                                            break;

                                                        case "2":
                                                            Console.Write("Input Order ID whose invoice is to be deleted: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.DeleteInvoice(OrderID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "3":
                                                            Console.Write("Input Order ID whose invoice is to be printed: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.WriteLine(waiter.PrintInvoice(OrderID));
                                                            Console.ReadKey();
                                                            break;

                                                        case "4":
                                                            Console.Write("Input Order ID whose invoice is to be printed: ");
                                                            OrderID = Int32.Parse(Console.ReadLine());
                                                            Console.Write("Input Payment Details: ");
                                                            string PaymentDetails = Console.ReadLine();
                                                            Console.WriteLine(waiter.AcceptPayment(OrderID, PaymentDetails));
                                                            Console.ReadKey();
                                                            break;

                                                        default:
                                                            Console.WriteLine("Invalid option. Please choose the options available.");
                                                            Console.ReadKey();
                                                            break;

                                                    }
                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option. Please choose the options available.");
                                                Console.ReadKey();
                                                break;

                                        }
                                    }                                   
                                }
                                else
                                {
                                    //CHEF MENU

                                    Chef chef = (stafftemp as Chef);
                                    bool showChefMenu = true;
                                    while (showChefMenu)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("======== CHEF MENU ========");
                                        Console.WriteLine("1. Get Order");
                                        Console.WriteLine("2. Cook Order");
                                        Console.WriteLine("3. Finish Cooking Order");
                                        Console.WriteLine("0. Log Out");
                                        Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");
                                        switch (Console.ReadLine())
                                        {
                                            case "0":
                                                showChefMenu = false;
                                                break;
                                            case "1":
                                                Console.WriteLine(chef.ReadOrder());
                                                Console.ReadKey();
                                                break;

                                            case "2":
                                                Console.Write("Input OrderID of the Order to be cooked: ");
                                                Console.WriteLine(chef.CookOrder(Int32.Parse(Console.ReadLine())));
                                                Console.ReadKey();
                                                break;

                                            case "3":
                                                Console.Write("Input OrderID of the finished Order: ");
                                                Console.WriteLine(chef.FinishCookingOrder(Int32.Parse(Console.ReadLine())));
                                                Console.ReadKey();
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option. Please choose the options available.");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }                                    
                                }
                            }                            
                        }
                        break;

                    case "3":
                        
                        //CUSTOMER MENU

                        bool showCustomerMenu = true;
                        while (showCustomerMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("1. Read Menu");
                            Console.WriteLine("2. Read Reservation");
                            Console.WriteLine("3. Read Order");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.Write("[INPUT NUMBERS ONLY]   Choose an option:  ");
                            switch (Console.ReadLine())
                            {
                                case "0":
                                    showCustomerMenu = false;
                                    break;

                                case "1":
                                    Console.WriteLine(_Customer1.ReadMenu());
                                    Console.ReadKey();
                                    break;                                

                                case "2":
                                    Console.WriteLine(_Customer1.ReadReservation());
                                    Console.ReadKey();
                                    break;

                                case "3":
                                    Console.WriteLine(_Customer1.ReadOrder());
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Invalid option. Please choose the options available.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose the options available.");
                        Console.ReadKey();
                        break; 

                }
            }
        }        
    }
}
