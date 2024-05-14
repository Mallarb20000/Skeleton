using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCms = new clsCustomer();

            // test to see that it exists
            Assert.IsNotNull(AnCms);

        }
    }


    [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class that we want to create
            clsCustomer AnCms = new clsCustomer();

            //create some test data to assign to the property
            Boolean TestData= true;

            //Assign the data to the property
            AnCms.Active = TestData;

           
            //test to see if the values are the same 
            Assert.AreEqual(AnCms.Active, TestData);

        }
    [TestMethod]
    public void DateAddedPropertyOk()
    {
        //create an instance of the class that we want to create
        clsCustomer AnCms = new clsCustomer();

        //create some test data to assign to the property
        DateTime TestData = DtaeTime.Now.Date;

        //Assign the data to the property
        AnCms.DateAdded = TestData;


        //test to see if the values are the same 
        Assert.AreEqual(AnCms.DateAdded, TestData);

    }
  
    public void PostCodePropertyOK()
    {
        //create an instance of the class we want to create 
        clsCustomer AnCms = new AnCms();
        //create some test data to assign to the property 
        string TestData = "LE1 4AB";
        //assign the data to the property 
        AnCms.PostCode = TestData;
        //test to see that the two values are the same 
        Assert.AreEqual(AnCms.PostCode, TestData);
    }
    [TestMethod]
    public void AddressIdPropertyOK()
    {
        //create an instance of the class we want to create 
        clsCustomer AnCms = new AnCms();
        //create some test data to assign to the property 
        Int32 TestData = 1;
        //assign the data to the property 
        AnCms.CmsId = TestData;
        //test to see that the two values are the same 
        Assert.AreEqual(AnCms.CmsId, TestData);
    }

}
    }

}
