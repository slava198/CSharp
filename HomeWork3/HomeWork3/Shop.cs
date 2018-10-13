/*
 * Created by SharpDevelop.
 * User: Слава
 * Date: 11.10.2018
 * Time: 23:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace HomeWork3
{
	public enum ArticleType	{ Motherboard, Processor, HDD, RAM, GraphicCards, PowerSupply }
	public enum ClientType	{ Usual, Advanced, Premium }
	public enum PayType 	{ Cash, Card }
	
	public struct Article
	{
		public int productID;
		public string productName;
		public double productPrice;
		public ArticleType productType;
	};
	
	public struct Client
	{
		public int clientID;
		public string clientName;
		public string clientAdress;
		public long clientPhone;
		public int clientQuantityOfOrders;
		public double clientSpendMoney;
		public ClientType clientType;
	};
	
	public struct RequestItem
	{
		public Article item;
		public int itemQuantity;		
	};
	
	public struct Request
	{
		public int requestID;
		public Client client;
		public DateTime date;
		public Article[] items;
		public int itemQuantity;
		public double totalPrice;
		public PayType payType;
		
		public double TotalPrice
		{
			get { return totalPrice; }
			set
			{
				value = 0;
				foreach (var element in items)
				{
					value += element.productPrice;
				}
				totalPrice = value;
			}
		}
				
	};
	
}