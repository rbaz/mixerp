﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;

namespace MixERP.Net.WebControls.ReportEngine
{
    public partial class Report
    {
        HiddenField reportHidden;
        HiddenField reportTitleHidden;

        private void AddHiddenControls(Panel p)
        {
            reportHidden = new HiddenField();
            reportHidden.ID = "ReportHidden";
            p.Controls.Add(reportHidden);

            reportTitleHidden = new HiddenField();
            reportTitleHidden.ID = "ReportTitleHidden";
            p.Controls.Add(reportTitleHidden);
        }
    }
}
