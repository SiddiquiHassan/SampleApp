
//(function ($) {

//    $.fn.testMethod = function (type) {
//        let l = $('<' + type + '>');
//		this.each(function (i, item) {
//			$(l).append($('<li>').append(item));
//		});
//		return l;
//    }

//}(jQuery));




(function ($) {

    $.fn.staticCombo = function (placeholder, datasource, valuefield, textfield) {

        $(this).kendoComboBox({
            placeholder: placeholder,
            dataValueField: valuefield,
            dataTextField: textfield,
            dataSource: datasource
        });
    };

    $.fn.dynamicCombo = function (config) {
        $(this).kendoComboBox({
            placeholder: config.placeholder,
            dataValueField: config.valueField,
            dataTextField: config.textField,
            dataSource: {
                transport: {
                    read: {
                        dataType: "json",
                        url: config.url
                    }
                }
            }
        });
    };

}(jQuery));

