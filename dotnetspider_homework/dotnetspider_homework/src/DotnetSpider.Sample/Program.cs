using System;
using System.Collections.Generic;
using System.Linq;

namespace DotnetSpider.Sample
{

	public class Program
	{
		public static void Main(string[] args)
		{
			CustomSpider1 s = new CustomSpider1();
			s.Run();
			//ConfigurableSpider.Run();

            /*优酷网
			// Custmize processor and pipeline 完全自定义页面解析和数据管道
			BaseUsage.CustmizeProcessorAndPipeline();
			Console.WriteLine("Press any key to continue...");
			Console.Read();

			// Crawler pages without traverse 采集指定页面不做遍历
			BaseUsage.CrawlerPagesWithoutTraverse();
			Console.WriteLine("Press any key to continue...");
			Console.Read();

			// Crawler pages traversal 遍历整站
			BaseUsage.CrawlerPagesTraversal();
			Console.WriteLine("Press any key to continue...");
			Console.Read();   */


            /*灯品汇
			DDengEntitySpider dDengEntitySpider = new DDengEntitySpider();
			dDengEntitySpider.Run();
			Console.WriteLine("Press any key to continue...");
			Console.Read();  */

            /*博客园
			Cnblogs.Run();
			Console.WriteLine("Press any key to continue...");
			Console.Read();  */


            /*中科大
			CasSpider casSpider = new CasSpider();
			casSpider.Run();
			Console.WriteLine("Press any key to continue...");
			Console.Read();
            */

            //百度搜索
			BaiduSearchSpider baiduSearchSpider = new BaiduSearchSpider();
			baiduSearchSpider.Run();
			Console.WriteLine("Welcome！");
            Console.WriteLine("This is the results of searching \"Taobao 618 \"");
			Console.Read();


            /*   京东网
			JdSkuSampleSpider jdSkuSampleSpider = new JdSkuSampleSpider();
			jdSkuSampleSpider.Run();
			Console.WriteLine("Press any key to continue...");
			Console.Read();

			Situoli.Run();   */
		}
	}
}
