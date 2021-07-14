using System;
using Business.DTOs;

namespace Business.CustomEventArgs
{
	public class UpdatePlayCountEventArgs:EventArgs
	{
		public SongDTO Song { get; set; }
		public int OldPlayCount { get; set; }
		public int NewPlayCount { get; set; }
	}
}