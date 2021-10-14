// M012_Extention_Records.Employee
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using M012_Extention_Records;

namespace M012_Extention_Records.GeneratedRecordClass
{


	public class Employee : IEquatable<Employee>
	{
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(Employee);
			}
		}

		public string Name { get; set/*init*/; }

		public Employee(string Name)
			:base()
		{
			this.Name = Name;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Employee");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(" ");
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		protected virtual bool PrintMembers(StringBuilder builder)
		{
			builder.Append("Name");
			builder.Append(" = ");
			builder.Append((object?)Name);
			return true;
		}

		public static bool operator !=(Employee? left, Employee? right)
		{
			return !(left == right);
		}

		public static bool operator ==(Employee? left, Employee? right)
		{
			return (object)left == right || (left?.Equals(right) ?? false);
		}

		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
		}

		public override bool Equals(object? obj)
		{
			return Equals(obj as Employee);
		}

		public virtual bool Equals(Employee? other)
		{
			return (object)this == other || ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other!.Name));
		}

		//public virtual Employee<Clone>()
		//{
		//	return new Employee(this);
		//}

		protected Employee(Employee original)
		{
			Name = original.Name;
		}

		public void Deconstruct(out string Name)
		{
			Name = this.Name;
		}
	}

}
