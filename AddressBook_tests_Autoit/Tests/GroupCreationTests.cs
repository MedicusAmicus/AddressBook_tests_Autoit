﻿using NUnit.Framework;
using System.Collections.Generic;

namespace AddressBook_tests_Autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            GroupData newGroup = new GroupData()
            {
                Name = "NewGroupName"
            };

            app.Groups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}