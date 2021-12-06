using System;
using System.Collections.Generic;

namespace AddressBook_tests_Autoit
{
    public class GroupHelper : HelperBase
    {
        public static string GroupWindowTitle = "Group editor";

        public GroupHelper(ApplicationManager manager) : base(manager) { }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupsDialogue();
            string count = aux.ControlTreeView(GroupWindowTitle, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "GetItemCount", "#0", "");
            for (int i=0; i < int.Parse(count); i++)
            {
                string item = aux.ControlTreeView(GroupWindowTitle, "", "WindowsForms10.SysTreeView32.app.0.2c908d51", "GetText", "#0|#"+i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }
            CloseGroupsDialogue();
            return list;
        }

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialogue();
            CreateGroup(newGroup);
            CloseGroupsDialogue();
        }

        private void CreateGroup(GroupData newGroup)
        {
            aux.ControlClick(GroupWindowTitle, "", "WindowsForms10.BUTTON.app.0.2c908d53");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
        }

        private void CloseGroupsDialogue()
        {
            aux.ControlClick(GroupWindowTitle, "", "WindowsForms10.BUTTON.app.0.2c908d54");
        }

        private void OpenGroupsDialogue()
        {
            aux.ControlClick(WindowTitle, "", "WindowsForms10.BUTTON.app.0.2c908d512");
            aux.WinWait(GroupWindowTitle);
        }
    }
}
