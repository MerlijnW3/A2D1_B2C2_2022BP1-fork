﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoListModel.Models;

namespace ToDoListModel.DataLayer
{
    /// <summary>
    /// Interface for the dataaccesslayer
    /// </summary>
    public interface IDataAccessLayer
    {
        /// <summary>
        /// Persist the task in the datastore
        /// </summary>
        /// <param name="ToDoTask">The task to persist</param>
        /// <returns>The persisted task</returns>
        public ToDoTask CreateToDoTask(ToDoTask ToDoTask);
        /// <summary>
        /// Read a specific task from the datastore
        /// </summary>
        /// <param name="id">The task to read</param>
        /// <returns>The specific task</returns>
        public ToDoTask ReadToDoTask(int id);
        /// <summary>
        /// Read all tasks from the datastore
        /// </summary>
        /// <returns>A list with all tasks</returns>
        public List<ToDoTask> ReadToDoTasks();
        /// <summary>
        /// Update the task in the datastore
        /// </summary>
        /// <param name="ToDoTask">The task to update</param>
        /// <returns>The updated task</returns>
        public ToDoTask UpdateToDoTask(ToDoTask ToDoTask);
        /// <summary>
        /// Delete the task fropm the datastore
        /// </summary>
        /// <param name="ToDoTask">The task to delete</param>
        /// <returns>True on success</returns>
        public bool DeleteToDoTask(ToDoTask ToDoTask);
    }
}
