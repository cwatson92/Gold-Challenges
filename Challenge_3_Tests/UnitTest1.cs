using System;
using System.Collections.Generic;
using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_3_Tests
{
    [TestClass]
    public class EventTest
    {
        Event_Repo outingrepo = new Event_Repo();
        [TestMethod]
        public void EventRepository_GetList_CountShouldBeTheSame()
        {
            //--Arrange
            List<Event> templist = outingrepo.GetList();

            //--Act
            int actual = templist.Count;
            int expected = 4;

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        
        
    }
}
