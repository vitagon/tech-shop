import React, { Component } from "react";
import { Table, Button } from 'react-bootstrap';
import axios from 'axios';
import { connect } from 'react-redux';

class CategoriesList extends Component {
  constructor(props) {
    super(props);
    this.state = {
      categories: []
    }
    //this.getCategories();
  }

  async getCategories() {
    let response;
    try {
      response = await axios.get('https://localhost:5001/api/categories')
    } catch (error) {
      console.error(error.response);
    }
    
    this.setState({
      categories: response.data
    });
  }

  changeCategory() {
    this.setState({
      categories: [
        ...this.state.categories,
        {name: 'Schemas'}
      ]
    })
  }

  render() {
    let categoriesEl = [];

    //for (const [index, value] of this.state.categories.entries()) {
    for (const [index, value] of this.props.categories.entries()) {
      categoriesEl.push(
        <tr key={index}>
          <td>{value.id}</td>
          <td>{value.name}</td>
          <td>{value.parentId}</td>
          <td>
            <Button variant="primary" size="sm" className="mr-2">Edit</Button>
            <Button variant="danger" size="sm">Delete</Button>
          </td>
        </tr>
      )
    }

    return (
      <Table striped bordered hover size="sm">
        <thead>
          <tr>
            <th>#</th>
            <th>Name</th>
            <th>Parent</th>
            <th style={{width: '117px'}}>Controls</th>
          </tr>
        </thead>
        <tbody>
          {categoriesEl}
        </tbody>
      </Table>
    );
  }
};

const mapStateToProps = (state) => {
  return {
    categories: state.categories
  }
}

export default connect(mapStateToProps)(CategoriesList);