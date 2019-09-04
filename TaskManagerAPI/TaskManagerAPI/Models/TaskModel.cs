﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskManagerAPI.Models
{
    public class TaskModel
    {
        //TaskID for TaskModel
        public int TaskId { get; set; }
        public string TaskName { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public int Priority { get; set; }

        public bool IsCompleted { get; set; }

        public IEnumerable<UsersModel> Users { get; set; }

    }
}
