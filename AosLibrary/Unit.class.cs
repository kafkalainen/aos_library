using System;

namespace AosLibrary;

//REVISIT: partial
public partial class Unit
{
	private int id { get; set; }
	private string name { get; set; }
	private Characteristics characteristics { get; set; }
	private Weapon weapon { get; set; }
}
