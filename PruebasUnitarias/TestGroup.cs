using System;
using Negocio;
using System.Data;
using Datos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class TestGroup
    {
        [TestMethod]
        public void AnewGroup()
        {
            ModelGroup group = new ModelGroup();
            group.groupName = "gpTest";
            group.shift = "Night";
            group.insertGroup(123);
            Globals.groupId = group.groupId;
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void BmodifyGroup()
        {
            ModelGroup group = new ModelGroup();
            group.groupId = Globals.groupId;
            group.groupName = "testGP";
            group.shift = "Morning";
            group.modifyGroup();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void CgetGroups()
        {
            ModelGroup groupList = new ModelGroup();
            DataTable groups = groupList.listGroups();
            DataRow group = groups.Rows[groups.Rows.Count - 1];
            Assert.IsTrue(
                group[1].ToString() == "testEstEst" &&
                group[2].ToString() == "testGP" &&
                group[3].ToString() == "Morning"
                );
        }
        [TestMethod]
        public void DdeleteGroup()
        {
            ModelGroup group = new ModelGroup();
            group.groupId = Globals.groupId;
            Console.WriteLine("" + group.groupId);
            group.deleteGroup();
            Assert.IsTrue(true);
        }
    }
}
