using System;
using System.Collections.Generic;
namespace HW_11._2n3
{
	public class Client
	{
		static Random randomize = new Random();
		static Client()
		{
			randomize = new Random();
		}

		/// <summary>
		/// Создание клиента
		/// </summary>
		/// <param name="SecondName"></param>
		/// <param name="FirstName"></param>
		/// <param name="Patronymic"></param>
		/// <param name="MobileNumber"></param>
		/// <param name="IdNumber"></param>
		public Client(string SecondName, string FirstName, string Patronymic,
		string MobileNumber, string IdNumber, string IndexClient, string Changes)
		{
			if (SecondName == String.Empty) { SecondName = $"{Guid.NewGuid().ToString().Substring(0, 5)}"; }
			this.secondName = SecondName;

			if (FirstName == String.Empty) { FirstName = $"{Guid.NewGuid().ToString().Substring(0, 5)}"; }
			this.firstName = FirstName;

			if (Patronymic == String.Empty) { Patronymic = $"{Guid.NewGuid().ToString().Substring(0, 5)}"; }
			this.patronymic = Patronymic;

			if (MobileNumber == String.Empty) { MobileNumber = $"0000000000"; }
			this.mobileNumber = MobileNumber;

			if (IdNumber == String.Empty) { IdNumber = $"0000 000000"; }
			this.idNumber = IdNumber;

			this.indexClient = IndexClient;

			this.changes = Changes;
		}

		/// <summary>
		/// Создание клиента с автопарамерами
		/// </summary>
		public Client() : this("", "", "", "", "", "", "")
		{ }

		private string secondName; // Поле фамилии
		private string firstName; // Поле имени
		private string patronymic; // Поле отчества
		private string mobileNumber; // Поле мобильного номера телефона
		private string idNumber; // Поле номера паспорта
		private string indexClient; // Индекс клиента в базе данных
		private string changes; // Информация об изменениях

		/// <summary>
		/// Фамилия
		/// </summary>
		public string SecondName 
		{
			get { return this.secondName; }
			set { this.secondName = value; }
		}

		/// <summary>
		/// Имя
		/// </summary>
		public string FirstName
		{
			get { return this.firstName; }
			set { this.firstName = value; }
		}

		/// <summary>
		/// Отчество
		/// </summary>
		public string Patronymic
		{
			get { return this.patronymic; }
			set { this.patronymic = value; }
		}

		/// <summary>
		/// Мобильный телефон
		/// </summary>
		public string MobileNumber
		{
			get { return this.mobileNumber; }
			set { this.mobileNumber = value; }
		}

		/// <summary>
		/// Серия и номер паспорта
		/// </summary>
		public string IdNumber
		{
			get { return this.idNumber; }
			set { this.idNumber = value; }
		}

		/// <summary>
		/// Индекс
		/// </summary>
		public string IndexClient
		{
			get { return this.indexClient; }
			set { this.indexClient = value; }
		}

		/// <summary>
        /// Внесенные изменения
        /// </summary>
		public string Changes
		{
			get { return this.changes; }
			set { this.changes = value; }
		}

		/// <summary>
		/// Информация о клиенте
		/// </summary>
		/// <returns></returns>
		public string ClientInformation()
		{
			return String.Format("Second Name:{0,-10} | First Name: {1,-15} | " +
				"Patronymic: {2 ,-15} | Mobile Number: {3, -11} | Id Number: {4, -12} | Id {5, -4} " +
                "| Changes: {6, -30}",
				this.secondName,
				this.firstName,
				this.patronymic,
				this.mobileNumber,
				this.idNumber,
				this.indexClient,
				this.changes
				) ;
		}

		/// <summary>
        /// Создание коллекции авто клиентов
        /// </summary>
        /// <param name="j"></param>
		public List<Client> NumOfClientsCreation(int j)
		{
			//Создаем коллекцию для хранения клиентов
			List<Client> clients = new List<Client>();

			//Наполняем коллекцию клиентами савтопараметрами
			for (int i = 0; i < +j; i++)
			{
				clients.Add(new Client("", "", "", "", "", i.ToString(), ""));
			}
			return clients;
		}
	}
}
