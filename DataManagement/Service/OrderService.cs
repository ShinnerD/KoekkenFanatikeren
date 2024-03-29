﻿using DataManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;

//OrderService skrevet og vedligeholdt af Dennis Kempf
namespace DataManagement.Service
{
    public class OrderService
    {
        private Repository.OrderRepository OrderRepository { get; set; }

        public OrderService()
        {
            OrderRepository = new Repository.OrderRepository();
        }

        /// <summary>
        /// Retrieves a list of Orders belonging to the Customer with the given Customer Id.
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public List<Model.Order> GetCustomerOrders(int customerId)
        {
            return OrderRepository.GetOrdersFromCustomer(customerId);
        }

        /// <summary>
        /// Retrieves a list of All Orders from the OrderRepository.
        /// </summary>
        /// <returns></returns>
        public List<Model.Order> GetAllOrders()
        {
            return OrderRepository.GetAllOrders();
        }

        /// <summary>
        /// Retrieves one Order from the Repository that matches the parameter Id.
        /// </summary>
        /// <param name="id">Order Id</param>
        /// <returns></returns>
        public Model.Order GetOrderFromId(int id)
        {
            return OrderRepository.GetOrderFromOrderId(id);
        }

        /// <summary>
        /// Saves an Order in the Database.
        /// </summary>
        /// <param name="order"></param>
        public void SaveOrder(Order order)
        {
            OrderRepository.SaveOrder(order);
        }

        /// <summary>
        /// Deletes an Order in the Database.
        /// </summary>
        /// <param name="order"></param>
        public void DeleteOrder(Order order)
        {
            OrderRepository.DeleteOrder(order);
        }

        /// <summary>
        /// Takes a List<Order> parameter and returns it sorted by date ascending.
        /// </summary>
        /// <param name="targetList">The List of Orders to sort.</param>
        /// <returns></returns>
        public List<Model.Order> SortByDateAscending(List<Model.Order> targetList)
        {
            return targetList.OrderBy(i => i.DateOfSending).ToList();
        }

        /// <summary>
        /// Takes a List<Order> parameter and returns it sorted by date ascending.
        /// </summary>
        /// <param name="targetList">The List of Orders to sort.</param>
        /// <returns></returns>
        public List<Model.Order> SortByDateDescending(List<Model.Order> targetList)
        {
            return targetList.OrderByDescending(i => i.DateOfSending).ToList();
        }

        /// <summary>
        /// Takes a List<Order> parameter and returns it with Orders only from within the start and end datetime range.
        /// </summary>
        /// <param name="targetList">The List to filter.</param>
        /// <param name="startDate">DateTime start date.</param>
        /// <param name="endDate">DateTime end date.</param>
        /// <returns></returns>
        public List<Model.Order> FilterByDate(List<Model.Order> targetList, DateTime startDate, DateTime endDate)
        {
            return targetList.Where(i => i.DateOfSending >= startDate && i.DateOfSending <= endDate).ToList();
        }
    }
}