using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_11._2n3

{
    public class Manager
    {
        
        /// <summary>
        /// Смена номера телефона
        /// </summary>
        /// <param name="client"></param>
        public virtual void MobNumChange(Client client)
        {
            char key = 'д';
            do
            {
                Console.WriteLine("Введите номер телефона клиента:");
                string str = Console.ReadLine();
                if (String.IsNullOrEmpty(str) || str.Contains(" "))
                {
                    Console.WriteLine("Данная строка не может быть пустой!");
                    Console.WriteLine("Ввести заново? н/д");
                    key = Console.ReadKey(true).KeyChar;
                }
                else
                {
                    client.MobileNumber = str;
                    break;
                }
            } while (char.ToLower(key) == 'д');
        }

        /// <summary>
        /// Смена имени
        /// </summary>
        /// <param name="client"></param>
        public virtual void FirstNameChange(Client client)
        {
            Console.WriteLine("Введите имя клиента:");
            string nam = Console.ReadLine();
            client.FirstName = nam;
        }

        /// <summary>
        /// Смена фамилии
        /// </summary>
        /// <param name="client"></param>
        public virtual void SecondNameChange(Client client)
        {
            Console.WriteLine("Введите фамилию клиента:");
            string nam = Console.ReadLine();
            client.SecondName = nam;
        }

        /// <summary>
        /// Смена отчества
        /// </summary>
        /// <param name="client"></param>
        public virtual void PatronymicChange(Client client)
        {
            Console.WriteLine("Введите отчество клиента:");
            string nam = Console.ReadLine();
            client.Patronymic = nam;
        }

        /// <summary>
        /// Смена номера паспорта
        /// </summary>
        /// <param name="client"></param>
        public virtual void IdNumChange(Client client)
        {
            Console.WriteLine("Введите номер паспорта клиента:");
            string id = Console.ReadLine();
            client.IdNumber = id;
        }

        /// <summary>
        /// Вывод коллекции клиентов
        /// </summary>
        /// <param name="clients"></param>
        public virtual void ShowInfo(List<Client> clients)
        {
            foreach (var c in clients)
            {
                Console.WriteLine(string.Format("Second Name: {0,-10} | First Name:  {1,-15} | " +
                "Patronymic: {2 ,-15} | Mobile Number: {3, -11} | Id Number: {4, -12} | Id {5, -4} " +
                "\nChanges: {6, -100}\n",
                c.SecondName,
                c.FirstName,
                c.Patronymic,
                c.MobileNumber,
                c.IdNumber,
                c.IndexClient,
                c.Changes
                ));
            }
        }

        /// <summary>
        /// Добавление нового клиента
        /// </summary>
        /// <param name="clients"></param>
        public virtual void AddClient(List<Client> clients)
        {
            Client newClient = new Client();
            SecondNameChange(newClient);
            FirstNameChange(newClient);
            PatronymicChange(newClient);
            MobNumChange(newClient);
            IdNumChange(newClient);
            newClient.IndexClient = (clients.Count()).ToString();
            clients.Add(newClient);
        }

    }
}
