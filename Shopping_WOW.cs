using System;
using System.Collections.Generic;

namespace HW_01
{
    class Program
    {
        static void Main(string[] args)
        {
            User Jame = new User("Jame Watson", "emailjame@gmail.com");
            T_shirt James1 = new T_shirt("L", "Red",500f, "Screen Boy");
            T_shirt James2 = new T_shirt("M", "Black",750f, "Screen Plant");
            T_shirt James3 = new T_shirt("S", "Black",625f, "Screen Red Lady");
            Address Watson = new Address ("131/75 Phutthamonthon Road","Nakhon Pathom","10180");

            Jame.sent();  //ชื่อ
            Jame.Cart(Watson);  //ที่อยู่
            Jame.list(James1);  //เสื้อตัวที่ 1
            Jame.list(James2);  //เสื้อตัวที 2
            Jame.list(James3);  //เสื้อตัวที่ 3

            Watson.sent();
            James1.sent();
            James2.sent();
            James3.sent();

            Console.WriteLine("Total Cost : {0} Bath", James1.price + James2.price + James3.price);
            Console.ReadLine();
        }
        
    }
}

class T_shirt
{
    public string size;
    public string color;
    public float price;
    public string image;
    public T_shirt(string valuesize, string valuecolor, float valueprice, string valueimage)
    {
        size = valuesize;
        color = valuecolor;
        price = valueprice;
        image = valueimage;
    }
    public void sent() 
    {
        Console.WriteLine("Shirt Size :  {0}", this.size);
        Console.WriteLine("Shirt Color : {0}", this.color);
        Console.WriteLine("Shirt Image : {0}", this.image);
        Console.WriteLine("Shirt Price : {0}", this.price);
    }

}
class User
{
    public string Name;
    public string email;
    public List<T_shirt> Shoppings_Oder;
    public User(string valueName, string valuemail)
    {
        Name = valueName;
        email = valuemail;
        Shoppings_Oder = new List<T_shirt>();
    }
    public void Cart(Address address) 
    {
        Shoppings_Oder = new List<T_shirt>();
        Address Watson = address;
    }
    public void list(T_shirt t_Shirt) 
    {
        Shoppings_Oder.Add(t_Shirt);
    }
    public void sent() 
    {
        Console.WriteLine("User_Name : {0}", this.Name);
        Console.WriteLine("User_E-mail : {0}", this.email);
    }
}
/*class ShoppingCart
{
    public List<T_shirt> t_Shirts;
    public float Totalcost;
    private List<Address> Addresses_;
    public void sent()
    {
        Console.WriteLine("t_shirt : {0}", this.t_Shirts);
        Console.WriteLine("TotalCost : {0}", this.Totalcost);
    }
   
}*/
class Address 
{
    public string street;
    public string city;
    public string zipCode;
    public Address(string valuestreet, string valuecity, string valuezipCode )
    {
        street = valuestreet;
        city = valuecity;
        zipCode = valuezipCode;
    }
    public void sent()
    {
        Console.WriteLine("Street : {0}", this.street);
        Console.WriteLine("City : {0}", this.city);
        Console.WriteLine("ZipCode : {0}", this.zipCode);
    }
}