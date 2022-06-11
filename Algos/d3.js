    contains (val);{
        if(this.isEmpty()){
            return false;
        } else {
            var runner = this.head;
            while (runner) {
                console.log(runner.data)
                if(runner.data == val){
                    return true
                }
                runner = runner.next
            }
            return false
        }
    }

    containsRecursive(val, runner = this.head); {
        if (this.isEmpty()) {
            return false;
        }
        else {
            if (runner.data == val){
                return true 
            } else {
                if (runner.next == null) {
                    return false 
                } else {
                    return this.containsRecursive(runner.next)
                }
            }
        }
    }

    // removeBack(){
    //     if (this.isEmpty()) {
    //         return null;
    //     } else {
    //         var runner = this.head;
    //         while (runner.next ){
    //             temp = runner.next 
    //             console.log(runner)
    //             runner.next = null
    //         }
    //     }
    // }





    console.log(sll.contains(2));

    console.log(sll.containsRecursive(5));
