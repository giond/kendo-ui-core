
package com.kendoui.taglib.stockchart;


import com.kendoui.taglib.BaseTag;






import javax.servlet.jsp.JspException;

@SuppressWarnings("serial")
public class NavigatorSelectMousewheelTag extends  BaseTag  /* interfaces */ /* interfaces */ {
    
    @Override
    public int doEndTag() throws JspException {
//>> doEndTag


        NavigatorSelectTag parent = (NavigatorSelectTag)findParentWithClass(NavigatorSelectTag.class);


        parent.setMousewheel(this);

//<< doEndTag

        return super.doEndTag();
    }

    @Override
    public void initialize() {
//>> initialize
//<< initialize

        super.initialize();
    }

    @Override
    public void destroy() {
//>> destroy
//<< destroy

        super.destroy();
    }

//>> Attributes

    public static String tagName() {
        return "stockChart-navigator-select-mousewheel";
    }

    public boolean getReverse() {
        return (Boolean)getProperty("reverse");
    }

    public void setReverse(boolean value) {
        setProperty("reverse", value);
    }

    public java.lang.String getZoom() {
        return (java.lang.String)getProperty("zoom");
    }

    public void setZoom(java.lang.String value) {
        setProperty("zoom", value);
    }

//<< Attributes

}