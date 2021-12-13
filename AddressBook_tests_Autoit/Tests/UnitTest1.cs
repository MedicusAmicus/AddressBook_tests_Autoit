using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace AddressBook_tests_Autoit
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemove()
        {
            int group_index = 8;
            while (app.Groups.GetGroupsCount() < group_index)
            {
                GroupData newGroup = new GroupData()
                {
                    Name = "NewGroupName"
                };
                app.Groups.Add(newGroup);
                Console.Out.WriteLine("new group added");
            }

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(group_index);

            Assert.AreEqual(oldGroups.Count-1, app.Groups.GetGroupsCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(group_index-1);
          
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}