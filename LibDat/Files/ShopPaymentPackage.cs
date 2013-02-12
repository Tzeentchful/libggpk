﻿using System.IO;

namespace LibDat.Files
{
	public class ShopPaymentPackage : BaseDat
	{
		[StringIndex]
		public int Id { get; set; }
		[UserStringIndex]
		public int Text { get; set; }
		public int Coins { get; set; }
		public int Price { get; set; }

		public ShopPaymentPackage(BinaryReader inStream)
		{
			Id = inStream.ReadInt32();
			Text = inStream.ReadInt32();
			Coins = inStream.ReadInt32();
			Price = inStream.ReadInt32();
		}

		public override void Save(BinaryWriter outStream)
		{
			outStream.Write(Id);
			outStream.Write(Text);
			outStream.Write(Coins);
			outStream.Write(Price);
		}

		public override int GetSize()
		{
			return 0x10;
		}
	}
}