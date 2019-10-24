﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NesopsService.Hook.Models.ResponseModels
{
    public class GetResponseModel<TReadModel, TRequestModel>
        where TReadModel : class
        where TRequestModel : class, IRequestModelBase
    {
        public int total { get; private set; } = 0;
        public int limit { get; private set; } = 0;
        public int skip { get; private set; } = 0;
        public List<TReadModel> data { get; set; }
        private TRequestModel request { get; set; }
        public GetResponseModel(TReadModel model, TRequestModel requestModel)
        {
            request = requestModel;
            data = new List<TReadModel>();
            data.Add(model);
            CountTotal();
            SetLimitAndSkip();
        }
        public GetResponseModel(List<TReadModel> model, TRequestModel _requestModel)
        {
            data = model; 
            CountTotal();           
            SetLimitAndSkip();
            HandlePaging();

        }
        private void CountTotal()
        {
            this.total = this.data.Count;
        }
        private void SetLimitAndSkip()
        {
            this.limit = this.request.limit;
            this.skip = this.request.skip;
        }
        public void HandlePaging()
        {
            this.data = this.data.Skip(this.limit * this.skip).Take(this.limit).ToList();
        }
    }
}
