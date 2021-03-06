﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debby.Admin.Sample.Models.Northwind
{
	[Table("EmployeeTerritories")]
	public class EmployeeTerritory
	{
		[Key]
		public int EmployeeTerritoryID { get; set; }

		[ForeignKey("Employee")]
		public int EmployeeID { get; set; }

		[Required, ForeignKey("TerritoryID")]
		public Territory Territory { get; set; }
	}
}