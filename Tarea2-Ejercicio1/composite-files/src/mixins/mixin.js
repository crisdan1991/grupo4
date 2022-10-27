var HelperMixin = {
    methods:{
        consolePrint(obj){
            console.log(JSON.parse(JSON.stringify(obj)), null, 2);
        }
    }
};

export default HelperMixin;


