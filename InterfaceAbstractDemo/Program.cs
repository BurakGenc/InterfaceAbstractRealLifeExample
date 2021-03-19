using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using System;
using MernisServiceReference;
using InterfaceAbstractDemo.Adapters;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdepter()); ;
            customerManager.Save(new Customer {DateOfBirth=new DateTime(1998,1,24),FirstName="Burak",Id=1,LastName="Genç",NationalityId="23104176914" });
            Console.ReadLine();   
        }
    }
}
