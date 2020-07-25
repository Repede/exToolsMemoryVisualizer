using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extoolsMemoryVisualizer
{
	public class DatumDump
	{
		public class DatumEntry
		{
			public int Base;
			public int Instances;
			public int Modified_vars;
			public int Total;
		}

		public Dictionary<string, DatumEntry> Entries;
		public int Table;
		public int Total;
		public int Total_Instances;
	}

	public class MobDump
	{
		public class MobEntry
		{
			public int Base;
			public int Instances;
			public int Modified_vars;
			public int Total;
		}

		public Dictionary<string, MobEntry> Entries;
		public int Table;
		public int Total;
		public int Total_Instances;
	}

	public class ObjDump
	{
		public class ObjEntry
		{
			public int Base;
			public int Instances;
			public int Modified_vars;
			public int Total;
		}

		public Dictionary<string, ObjEntry> Entries;
		public int Table;
		public int Total;
		public int Total_Instances;
	}

	public class MemDump
	{
		public DatumDump Datum;
		public MobDump Mobs;
		public ObjDump Obj;

		public int Total;
		public int Total_Instances;
	}
}
