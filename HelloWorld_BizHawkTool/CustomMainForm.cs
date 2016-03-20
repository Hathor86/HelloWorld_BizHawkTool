using BizHawk.Client.Common;
using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BizHawk.Client.ApiHawk;

namespace BizHawk.Client.EmuHawk
{
	/// <summary>
	/// Here your first form
	/// /!\ it MUST be called CustomMainForm and implements IExternalToolForm
	/// Take also care of the namespace
	/// </summary>
	public partial class CustomMainForm : Form, IExternalToolForm
	{
		#region Fields

		/*
		The following stuff will be automatically filled
		by BizHawk runtime
		*/
		[RequiredService]
		internal IMemoryDomains _memoryDomains { get; set; }
		[RequiredService]
		private IEmulator _emu { get; set; }

		/*private members for our needed*/
		private WatchList _watches;

		#endregion

		#region cTor(s)

		public CustomMainForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		private void button1_Click(object sender, EventArgs e)
		{
			//ClientApi.DoframeAdvance();
		}

		#endregion

		#region BizHawk Required methods

		/// <summary>
		/// Return true if you want the <see cref="UpdateValues"/> method
		/// to be called before rendering
		/// </summary>
		public bool UpdateBefore
		{
			get
			{
				return true;
			}
		}

		public bool AskSaveChanges()
		{
			return true;
		}

		/// <summary>
		/// This method is called instead of regular <see cref="UpdateValues"/>
		/// when emulator is runnig in turbo mode
		/// </summary>
		public void FastUpdate()
		{ }

		/// <summary>
		/// Restart is called the first time you call the form
		/// but also when you start playing a movie
		/// </summary>
		public void Restart()
		{
			//set a client padding
			ClientApi.SetExtraPadding(50, 50);

			if (Global.Game.Name != "Null")
			{				
				//first initialization of WatchList
				if (_watches == null)
				{
					_watches = new WatchList(_memoryDomains, _emu.SystemId ?? string.Empty);

					//Create some watch
					Watch myFirstWatch = Watch.GenerateWatch(_memoryDomains.MainMemory, 0x40, WatchSize.Byte, BizHawk.Client.Common.DisplayType.Hex, true);
					Watch mySecondWatch = Watch.GenerateWatch(_memoryDomains.MainMemory, 0x50, WatchSize.Word, BizHawk.Client.Common.DisplayType.Unsigned, true);
					Watch myThirdWatch = Watch.GenerateWatch(_memoryDomains.MainMemory, 0x60, WatchSize.DWord, BizHawk.Client.Common.DisplayType.Hex, true);

					//add them into the list
					_watches.Add(myFirstWatch);
					_watches.Add(mySecondWatch);
					_watches.Add(myThirdWatch);

					label_Game.Text = string.Format("You're playing {0}", Global.Game.Name);
					label_GameHash.Text = string.Format("Hash: {0}", Global.Game.Hash);
				}
				//refresh it
				else
				{
					_watches.RefreshDomains(_memoryDomains);
					label_Game.Text = string.Format("You're playing {0}", Global.Game.Name);
					label_GameHash.Text = string.Format("Hash: {0}", Global.Game.Hash);
				}
			}
			else
			{
				label_Game.Text = string.Format("You aren't playing to anything");
				label_GameHash.Text = string.Empty;
			}
		}

		/// <summary>
		/// This method is called when a frame is rendered
		/// You can comapre it the lua equivalent emu.frameadvance()
		/// </summary>
		public void UpdateValues()
		{
			if (Global.Game.Name != "Null")
			{
				//we update our watches
				_watches.UpdateValues();
				label_Watch1.Text = string.Format("First watch ({0}) current value: {1}", _watches[0].AddressString, _watches[0].ValueString);
				label_Watch2.Text = string.Format("Second watch ({0}) current value: {1}", _watches[1].AddressString, _watches[1].ValueString);
				label_Watch3.Text = string.Format("Third watch ({0}) current value: {1}", _watches[2].AddressString, _watches[2].ValueString);
			}
		}

		#endregion BizHawk Required methods
	}
}
