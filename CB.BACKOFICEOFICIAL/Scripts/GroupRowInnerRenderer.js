function GroupRowInnerRenderer() { }

GroupRowInnerRenderer.prototype.init = function (params) {
    this.eGui = document.createElement('div');
    this.eGui.style.display = "inline-block";

    //var flagCode = params.flagCodes[params.node.key];

    var html = '';
    //if (flagCode) {
    //    html += '<img class="flag" border="0" width="20" height="15" src="https://flags.fmcdn.net/data/flags/mini/' + flagCode + '.png">';
    //}

    var node = params.node;
   // var node4 = params.value;
    var aggData = node.aggData;


    html += '<span class="groupTitle"> COUNTRY_NAME</span>'.replace('COUNTRY_NAME', node.key);
    html += '<button type="button" onclick="myFunction(\'' + node.key +'\');" class="btn btn-xs btn-warning"><i class="glyphicon glyphicon-eye-open"></i>&nbsp;</button>';
    //html += '<button onclick="myFunction(\'' + node.key + '\')"><span class="medal bronze">View</span></button>'
    html += '<span class="medal gold"> Monto Cuota: GOLD_COUNT</span>'.replace('GOLD_COUNT', round(aggData.MontoCuota,2));
    html += '<span class="medal silver"> Interes Mora: SILVER_COUNT</span>'.replace('SILVER_COUNT',  round(aggData.SaldoCuota,2));
    html += '<span class="medal bronze"> Total $: BRONZE_COUNT</span></button>'.replace('BRONZE_COUNT', round(aggData.TotalSus,2));
    html += '<span class="medal bronze"> Total Bs: BRONZE_COUNT</span></button>'.replace('BRONZE_COUNT', round(aggData.TotalBs,2));

    this.eGui.innerHTML = html;
};

GroupRowInnerRenderer.prototype.getGui = function () {
    return this.eGui;
};
