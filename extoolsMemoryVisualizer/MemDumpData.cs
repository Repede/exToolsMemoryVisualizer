using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extoolsMemoryVisualizer
{
	public static class MemDumpData
	{
		private static Dictionary<string, List<int>> m_EntryToTotal = new Dictionary<string, List<int>>();

		public static Dictionary<string, List<int>> GenerateData(List<MemDump> memDumps, out int highestCount)
		{
			m_EntryToTotal.Clear();
			highestCount = 0;

			for (int i = 0; i < memDumps.Count; ++i)
			{
				MemDump dump = memDumps[i];
				foreach(string key in dump.Datum.Entries.Keys)
				{
					if(!m_EntryToTotal.ContainsKey(key))
					{
						m_EntryToTotal.Add(key, new List<int>());
					}

					m_EntryToTotal[key].Add(dump.Datum.Entries[key].Total);
					if(m_EntryToTotal[key].Count > highestCount)
					{
						highestCount = m_EntryToTotal[key].Count;
					}
				}
			}

			return m_EntryToTotal;
		}
	}
}
