using System;
using System.Text;

namespace Append
{
	class buscador
	{
		public static void Main(StringBuilder buf, string cs)
		{

			if (cs == null)
			{
				return;
			}
			for (int i = 0; i < cs.length(); i++)
			{
				char c = cs.charAt(i);
				switch (c)
				{
					case '\\':
						buf.append("\\\\");
						break;
					case '"':
						buf.append("\\\"");
						break;
					case '\n':
						buf.append("\\n");
						break;
					case '\r':
						buf.append("\\r");
						break;
					default:
						buf.append(c);
						break;
				}
			}
		}
	}
}