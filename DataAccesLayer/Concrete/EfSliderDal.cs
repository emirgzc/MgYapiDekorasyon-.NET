﻿using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
	public class EfSliderDal : EfEntityRepositoryBase<Slider, Context>, ISliderDal
	{
	}
}
