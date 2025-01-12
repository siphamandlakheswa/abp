﻿using JetBrains.Annotations;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form.DatePicker;

[HtmlTargetElement("abp-date-range-picker", TagStructure = TagStructure.NormalOrSelfClosing)]
public class AbpDateRangePickerTagHelper : AbpDatePickerBaseTagHelper<AbpDateRangePickerTagHelper>
{
    [CanBeNull] 
    public ModelExpression AspForStart { get; set; }

    [CanBeNull] 
    public ModelExpression AspForEnd { get; set; }

    public AbpDateRangePickerTagHelper(AbpDateRangePickerTagHelperService tagHelperService) :
        base(tagHelperService)
    {
    }
}