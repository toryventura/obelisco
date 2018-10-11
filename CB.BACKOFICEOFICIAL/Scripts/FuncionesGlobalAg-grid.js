function setDataSource(allOfTheData, grid) {
    
    grid.api.setRowData(allOfTheData);
    //grid.api.setDatasource(dataSource);

}

function createGlobal(gridOptions, gridDiv) {
    new agGrid.Grid(gridDiv, gridOptions);
}



function destroyGlobal(grid) {
    grid.api.destroy();
}

function round(value, precision) {
			var aPrecision = Math.pow(10, precision);
			return Math.round(value*aPrecision)/aPrecision;
}