import React from 'react';
const { Component } = require("react");

class Task extends Component{
    constructor(props){
        super(props);

        this.state = {
            activeItem : -1, 
            items : ['a', 'b'],
        }
    }
    handleItemClicked(index){
        this.setState({
            activeItem : index,
        })
    }

    render(){
        return (
            <div>
                <ul>
                    {this.state.items.map((item, index) => 
                        <li key={index} className={this.state.activeItem === index ? 'navigation--active' : ''} onClick={this.handleItemClicked}>
                            {item}
                        </li>
                    )}
                </ul>
            </div>
        );
    }
}

export default Task