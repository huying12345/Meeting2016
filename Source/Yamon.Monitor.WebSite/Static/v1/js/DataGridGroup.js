﻿jQuery(function () {
    window.onresize = setGridHeight;
    jQuery('#tt').datagrid({
        url: 'Handler/SmartFormHandler.ashx?action=grid' + Data.BaseUrl,
        title: '',
        fitColumns: false, // 设置横向滚动条没有，宽度永远只有那么大
        striped: true, // 行是否隔行换样式
        pagination: true, // 显示分页
        pageSize: Data.PageSize,
        nowrap: true,
        loadMsg: '数据加载中，请稍等...', // 显示加载信息
        rownumbers: true, // 显示序号
        singleSelect: false, // 单选一行
        sortName: Data.SortField,
        sortOrder: Data.OrderType,
        remoteSort: true,
        idField: Data.PrimaryKey,
        frozenColumns:Data.frozenColumns,
        columns: Data.columns,
        onBeforeLoad: function (row, param) {
            jQuery(this).datagrid('unselectAll');
        },
        toolbar: Data.toolbar,
        onHeaderContextMenu: function (e, field) {
            e.preventDefault();
            if (!jQuery('#tmenu').length) {
                createColumnMenu();
            }
            jQuery('#tmenu').menu('show', {
                left: e.pageX,
                top: e.pageY
            });
        },
        onDblClickRow: function (rowIndex, rowData) {
            Grid_DblClickRow(rowIndex, rowData);
        },
        onClickRow: function (rowIndex) {

        },
        groupField: Data.GroupField,
        view: groupview,
        groupFormatter: function (value, rows) {
            return value + ' - ' + rows.length + Data.ItemUnit + Data.ItemName;
        },
        onSortColumn: function (sort, order) {
            // jQuery('#tt').datagrid("options").groupField = sort;
            return false;
        }, onDblClickRow: function (rowIndex, rowData) {
            OpenDialog_ViewFormByID(rowData[Data.PrimaryKey]);
        }, onLoadError: function () {
            $.messager.alert('加载数据出错', "加载数据出错", 'error');
        },
        onLoadSuccess: function (data) {
            if (data.total == "-1") {
                $.messager.alert('加载数据出错', data.msg, 'error');
            }
        }
    });

    setGridHeight();
    jQuery("#p").css("height", jQuery("#searchtable").css("height") + 100);
    jQuery("#p").css("width", jQuery("#searchtable").css("width") + 100);
    jQuery("#btnSubmit")
			.click(
					function () {
					 
					    $('#tt').datagrid("options").url = "Handler/SmartFormHandler.ashx?action=grid"
								+ GetBaseUrl(Data.BaseUrl, '#searchForm')+"&"+ jQuery('#searchForm').formSerialize();
					    jQuery('#tt').datagrid('reload');
					});

    jQuery("#btnReset").click(function () {
        jQuery('#searchForm').form("clear");
    });
});
// 重新加载数据
function ReloadData() {
    jQuery('#tt').datagrid('reload');
    jQuery('#tt').datagrid('unselectAll');
}