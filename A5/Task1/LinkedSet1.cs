using System;
using System.Collections;
using System.Collections.Generic;

namespace A5.Task1
{
	public class LinkedSet1 : ISet
	{
		private DoublyLinkedList data = new DoublyLinkedList();

		public bool add(int value)
		{
			if (data.indexOf(value) != -1) 
			{ 
				return false; 
			}

			data.addFront(value);
			return true;
		}

		public void addMany(params int[] args)
		{
			foreach (var arg in args) 
			{ 
				this.add(arg); 
			}
		}

		public void addAll(ISet otherSet)
		{
			foreach (int node in otherSet) 
			{ 
				this.add(node); 
			}
		}

		public bool remove(int value)
		{
			try
            {
				data.remove(data.indexOf(value));
				return true;
			}
			catch
            {
				return false;
            }
		}

		public bool contains(int target)
		{
			return data.indexOf(target) != -1;
		}

		public int get(int index)
		{
			return data.get(index);
		}

		public int size()
		{
			return data.size();
		}

		public bool isEmpty()
		{
			return data.empty();
		}

		public void clear()
		{
			data.clear();
		}

		public String toString()
		{
			string str = "LinkedSet1[";
			for (int i = 0; i < data.size(); ++i)
			{
				str += data.size();
				if (i < data.size())
                {
					str += ", ";
                }
			}
			str += "]";

			return str;
		}

		public override bool Equals(Object other)
		{
			ISet set = (ISet)other;

			if (data == other) { return true; }
			if (other == null) { return false; }
			if (data.size() != set.size()) { return false; }

			for (int i = 0; i < data.size(); ++i)
			{
				if (!set.contains(data.get(i))) { return false; }
			}
			return true;
		}
		public IEnumerator GetEnumerator()
		{
			for (int i = 0; i < data.size(); ++i)
			{
				yield return data.get(i);
			}
		}
	}

}
