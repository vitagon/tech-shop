import React, { Component } from "react";
import { Table, Button } from 'react-bootstrap';
import { connect } from 'react-redux';
import {bindActionCreators} from 'redux';
import {fetchCategoriesAction} from '../../actions/categoriesActions';

class CategoriesList extends Component {

  constructor(props) {
    super(props);
    console.log(process.env.REACT_APP_API_URL);
  }

  handleClick = () => {
    this.props.fetchCategories();
  }

  render() {
    let categoriesEl = [];

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
      <div>
        <Button variant="primary" onClick={this.handleClick} block className="mb-3">Get categories</Button>
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