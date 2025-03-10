using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2_test
{
    internal class SinglyLinkedList<T>
    {
        public Node<T> Head { get; set; } // Първи елемент (глава) на списъка
        private Node<T> Tail { get; set; } // Последен елемент (опашка) на списъка  

        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
        }

        // Добавяне на елемент в началото на списъка
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            newNode.Next = Head; // Новият възел сочи към стария първи елемент
            Head = newNode; // Главата сочи към новия възел
        }

        // Премахване на елемент от началото на списъка
        public T RemoveFirst()
        {
            if (Head == null)
                throw new InvalidOperationException("Списъкът е празен");

            T removedData = Head.Data; // Запазване на премахнатите данни
            Head = Head.Next; // Главата сочи към следващия възел
            return removedData;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public T RemoveLast()
        {
            if (Head == null)
                throw new InvalidOperationException("Списъкът е празен");

            if (Head == Tail)
            {
                T data = Head.Data;
                Head = null;
                Tail = null;
                return data;
            }

            Node<T> current = Head;
            while (current.Next != Tail)
            {
                current = current.Next;
            }

            T removedData = Tail.Data;
            Tail = current;
            Tail.Next = null;
            return removedData;
        }


        // Търсене на елемент по стойност
        public bool Contains(T value)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(value)) // Проверка дали текущият възел съдържа търсената стойност
                    return true;
                current = current.Next; // Преминаване към следващия възел
            }
            return false;
        }

        // Проверка дали списъкът е празен
        public bool IsEmpty()
        {
            return Head == null;
        }

        public void PrintList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
