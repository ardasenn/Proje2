using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABOACIDIYET
{
    internal class Calcuiations
    {

        /*
        YZ.Calculator=YZ.Calculator||{},
        YZ.Calculator.Bmi=function(e,a)
        {
        function t()
        {
        var 
        e=l.getComponent("Height").getValue(),
        a=l.getComponent("Weight").getValue(),
        t=l.getComponent("Weight").getFactor(),
        n=l.getComponent("Age").getValue(),

        c=l.getComponent("Gender").getValue();

        e/=100,

        r.bmi=Math.round(a/(e*e)*10)/10,

        24>n?(r.idealBmiRangeBegin=19,r.idealBmiRangeEnd=24):
        34>n?(r.idealBmiRangeBegin=20,r.idealBmiRangeEnd=25):
        44>n?(r.idealBmiRangeBegin=21,r.idealBmiRangeEnd=26):
        54>n?(r.idealBmiRangeBegin=22,r.idealBmiRangeEnd=27):
        64>n?(r.idealBmiRangeBegin=23,r.idealBmiRangeEnd=28):

        (r.idealBmiRangeBegin=24,r.idealBmiRangeEnd=29),

        
        f===c&&(r.idealBmiRangeBegin-=1,r.idealBmiRangeEnd-=1),

        c yani Gender female ise başından sonundan -1 yap aralıkları

        r.idealWeightRangeBegin=Math.round(r.idealBmiRangeBegin*e*e*t*10)/10,
        r.idealWeightRangeEnd=Math.round(r.idealBmiRangeEnd*e*e*t*10)/10,
        r.currentWeight=Math.round(10*a*t)/10,


        YZ.Calculator.CalorieIntake=function(e,a)
        {
        function t()
        {
        var 
        e=l.getComponent("Height").getValue(),
        a=l.getComponent("Weight").getValue(),
        t=l.getComponent("Age").getValue(),
        n=l.getComponent("Gender").getValue(),
        c=l.getComponent("DailyActivity").getValue(),
        o="f"===n?-161:5, gender female ise o = -161 değilse 5
        s=10*a+6.25*e-5*t+o,
        u=16*c,
        d=7.6,
        g=(u+d)/24,
        p=YZ.Util.roundWithIncrement(g*s,10,0),
        m=.5,
        y=.1*a,  10da birini al
        v=a-(a-y),
        h=a-(a+y),
        f=750*v/(v/-m),
        z=750*h/(h/m),
        b=p+f,
        Y=p+z;
        b=s>b?s:b, s eğer b'den büyükse byi s yap küçükse byi b yap 
        r.caloriesMaintainMin=p-100,
        r.caloriesMaintainMax=p+100,
        r.caloriesGainMin=Y-100,
        r.caloriesGainMax=Y+100,
        r.caloriesLooseMin=b,
        r.caloriesLooseMax=b+100,

        YZ.Calculator.CaloriesBurned=function(e,a)
        {
        function t()
        {
        var 
        e=l.getComponent("Weight").getValue(),
        a=l.getComponent("Age").getValue(),
        t=l.getComponent("Duration").getValue(),
        n=l.getComponent("SportsAutocomplete").getValue(),
        c=l.getComponent("Gender").getValue(),
        o=70,
        s="f"===c?-161:5,
        u=10*e+6.25*o-5*a+s;
        r.calories=Math.round(t*u*n/1440),
        r.kilojoule=Math.round(4.1868*r.calories),
        r.minWalking=Math.round(r.calories/(3.5*u)*1400),
        r.minJogging=Math.round(r.calories/(11*u)*1400),
        r.minSwimming=Math.round(r.calories/(6*u)*1400),
        r.minCycling=Math.round(r.calories/(4u)1400),
        r.activity=l.getComponent("SportsAutocomplete").getActivity(),
        r.duration=t,

        YZ.Calculator.Idealweight=function(e,a)
        {function t()
        {var e=l.getComponent("Height").getValue(),
        t=l.getComponent("Age").getValue(),
        n=l.getComponent("Gender").getValue(),
        c="lbs"===a.weightUnit?2.2046:1;
        e/=100;
        var o=0,s=0;
        24>t?(o=19,s=24):
        34>t?(o=20,s=25):
        44>t?(o=21,s=26):
        54>t?(o=22,s=27):
        64>t?(o=23,s=28):
        (o=24,s=29),

        "f"===n&&(o-=1,s-=1),
        r.idealWeightRangeBegin=Math.round(o*e*e*c*10)/10,
        r.idealWeightRangeEnd=Math.round(s*e*e*c*10)/10,i()}
        */
        
    }
}
