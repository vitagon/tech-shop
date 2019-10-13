import React, { Component } from "react";
import { Table, Button } from 'react-bootstrap';
import { connect } from 'react-redux';
import {bindActionCreators} from 'redux';
import {fetchCategoriesAction} from '../../actions/categoriesActions';

class CategoriesList extends Component {
  constructor(props) {
    super(props);
    //this.getCategories();
  }

  // async getCategories() {
  //   this.setState({
  //     categories: response.data
  //   });
  // }

  handleClick = () => {
    this.props.fetchCategories();
  }

  render() {
    let categoriesEl = [];
    console.log(this.props);

    if (this.props.categories !== undefined) {
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
    }

    return (
      <div>
        <button onClick={this.handleClick}>Get categories</button>
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
      </div>
    );
  }
};

const mapStateToProps = (state, ownProps) => {
  return {
    categories: state.categoriesReducer.categories
  }
}

const mapDispatchToProps = (dispatch) => bindActionCreators({
  fetchCategories: fetchCategoriesAction
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(CategoriesList);